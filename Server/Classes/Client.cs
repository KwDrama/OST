using OSTLibrary.Chats;
using OSTLibrary.Classes;
using OSTLibrary.Networks;
using OSTLibrary.Securities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Server.Classes
{
    public class Client
    {
        public TcpClient socket;            // 클라이언트 소켓
        NetworkStream ns;                   // 네트워크 스트림
        public Thread recvThread;           // 클라이언트로부터 수신을 대기하는 스레드
        public Employee employee;           // 클라이언트의 사원 정보

        public Client(TcpClient socket)
        {
            this.socket = socket;
            ns = socket.GetStream();
            employee = new Employee(0, string.Empty);

            recvThread = new Thread(new ThreadStart(Recieve));
            recvThread.Start();
        }

        public void Recieve()
        {
            byte[] readBuffer = null, lengthBuffer = new byte[4];
            while (true)
            {
                // 패킷 읽기
                try
                {
                    // 패킷 길이 먼저 읽기
                    if (ns.Read(lengthBuffer, 0, 4) < 4)
                    {
                        Log("Receive", "패킷 길이를 읽지 못하였습니다.\n");

                        // 수신 버퍼 리셋
                        while (ns.ReadByte() != -1) ;
                    }
                    readBuffer = new byte[BitConverter.ToInt32(lengthBuffer, 0)];
                    int position = 0;

                    // 길이를 토대로 데이터 읽기 잘려서 와도 끝까지 읽음
                    while (position < readBuffer.Length)
                        position += ns.Read(readBuffer, position, readBuffer.Length - position);
                }
                catch (IOException socketEx)
                {
                    Log("IOException", socketEx.Message);
                    Program.RemoveClient(this);
                    break;
                }
                catch (Exception ex)
                {
                    Log("Exception", ex.ToString());
                    Program.RemoveClient(this);
                    break;
                }

                // 패킷 번역
                object pakcetObj = null;
                try
                {
                    pakcetObj = Packet.Deserialize(AES256.Decrypt(readBuffer));
                }
                catch (Exception ex)
                {
                    Log("Deserialize", ex.ToString());

                    // 수신 버퍼 리셋
                    while (ns.ReadByte() != -1) ;
                }
                if (pakcetObj == null) continue;

                Packet packet = pakcetObj as Packet;

                // 연결
                if (packet.type == PacketType.Header)
                {
                    Log("Warning", "Receieved no length HeaderPacket");
                }
                else if (packet.type == PacketType.Close)
                {
                    Log("Close", "Disconnect client");
                    socket.Close();
                    break;
                }

                // 로그인
                else if (packet.type == PacketType.Login)
                {
                    LoginPacket p = packet as LoginPacket;

                    Employee emp = Database.Login(p.employees[0].id, p.employees[0].password);
                    if (emp == null)
                    {
                        Log("Login", string.Format("{0} 로그인 실패", p.employees[0].id));
                        p.success = false;
                    }
                    else
                    {
                        employee = emp;
                        // 이미 접속되어 있었다면 이전에 접속한 클라이언트를 추방
                        if (!Program.MoveLoginClient(this))
                        {
                            Log("Login", "중복 로그인 발생하여 기존 클라이언트 추방");
                            Program.clients[emp.id].Send(new Packet(PacketType.DuplicateLogin));
                            Thread.Sleep(1000);

                            // 1초 후에도 살아있을 경우 강제 접속 종료
                            if (Program.clients.ContainsKey(emp.id) &&
                                Program.clients[emp.id].socket.Connected)
                                Program.clients[emp.id].socket.Close();

                            // 내가 로그인 처리가 될 때 까지 대기
                            while (Program.MoveLoginClient(this)) Thread.Sleep(400);
                        }

                        Log("Login", "로그인 성공");

                        // 로그인 하면서 불러온 사원의 룸 정보를 모두 룸과 사원 관계의 Map에 저장
                        List<Room> myRooms = Database.GetRooms(emp);
                        foreach (Room room in myRooms)
                        {
                            // 룸-사원 관계 리스트에서 사원이 없을 경우 추가
                            if (Program.roomEmps.ContainsKey(room.id))
                            {
                                if (!Program.roomEmps[room.id].Contains(employee.id))
                                    Program.roomEmps[room.id].Add(employee.id);
                            }
                            else
                                Program.roomEmps.Add(room.id, new List<int>(new int[] { employee.id }));

                            room.lastChat = Database.GetLastChat(room);
                        }       
                        // 로그인 하면서 불러온 사원의 스케줄 정보를 모두 스케줄과 사원 관계의 Map에 저장
                        List<Schedule> mySchedule = Database.GetSchedule(emp);
                        
                        p = new LoginPacket(true, Program.employees, myRooms, mySchedule);
                    }

                    Thread.Sleep(200);  // 클라이언트 스피너 보기 위함
                    Send(p);
                }
                else if (packet.type == PacketType.Logout)
                {
                    Program.MoveLogoutClient(this);
                    Log("Logout", "로그아웃");
                    employee = new Employee(0, string.Empty);
                }
                else if (packet.type == PacketType.Register)
                {
                    RegisterPacket p = packet as RegisterPacket;
                    if (p.success = Database.Register(p.employee))
                    {
                        Program.employees.Add(p.employee.id, employee = p.employee);
                        Log("Register", "회원가입 성공");
                    }
                    else
                        Log("Register", "회원가입 실패");
                    Send(p);
                }

                // 채팅
                else if (packet.type == PacketType.Room)
                {
                    RoomPacket p = packet as RoomPacket;
                    if (p.roomType == RoomType.New)
                    {
                        do p.room.id = MD5.NextRandom();
                        while (!Database.AddRoom(p.room));
                        Send(p);

                        Employee targetEmp = null;
                        if (p.room.scopeIdx == 3)
                        {
                            int otherEmpId = p.room.FindOtherEmployeeId(employee);
                            if (Program.employees.ContainsKey(otherEmpId))
                            {
                                targetEmp = Program.employees[p.room.FindOtherEmployeeId(employee)];
                                Log("Room", $"{Room.Scope[p.room.scopeIdx]} 채팅방 생성 : {targetEmp.name}({targetEmp.id})");
                            }
                            else
                            {
                                Log("Room", $"{Room.Scope[p.room.scopeIdx]} 채팅방 생성 실패");
                            }
                        }
                        else
                            Log("Room", $"{Room.Scope[p.room.scopeIdx]} 채팅방 생성 : {p.room.target}");

                        // 룸과 사원 관계 Map에도 저장, 새로 만드는 방이니깐 기존에 정보가 없었을 것임
                        Program.roomEmps.Add(p.room.id, new List<int>(new int[] { employee.id }));
                        if (targetEmp != null && Program.clients.ContainsKey(targetEmp.id) &&
                            !Program.roomEmps[p.room.id].Exists(e => e == targetEmp.id))
                            Program.roomEmps[p.room.id].Add(targetEmp.id);
                        
                    }
                    else if (p.roomType == RoomType.Chats)
                    {
                        // 로깅
                        if (p.room.scopeIdx == 3)
                        {
                            int otherEmpId = p.room.FindOtherEmployeeId(employee);
                            if (Program.employees.ContainsKey(otherEmpId))
                            {
                                Employee targetEmp = Program.employees[p.room.FindOtherEmployeeId(employee)];
                                Log("Room", $"{targetEmp.name}({targetEmp.id}) 채팅방 조회");
                            }
                            else
                            {
                                Log("Room", $"{Room.Scope[p.room.scopeIdx]} 채팅방 조회 실패");
                            }
                        }
                        else
                            Log("Room", $"{p.room.target} 채팅방 조회");

                        Send(new ChatsPacket(Database.GetChats(p.room, p.until)));
                    }
                }
                else if (packet.type == PacketType.Chat)
                {
                    ChatsPacket p = packet as ChatsPacket;
                    if (p.chats.Count == 0) continue;

                    // 클라한테 받은 채팅 내역 DB에 저장
                    if (!Database.AddChat(p.chats[0]))
                        Log("Chat", "채팅 내역 DB 저장 실패");
                    // 채팅 굳이 로깅할 필요 없을 것 같아서 주석 처리 함
                    //else
                    //    Log("Chat",
                    //        p.chats[0].type == ChatType.Text ? p.chats[0].text :
                    //        p.chats[0].type == ChatType.Image ? "사진" : "Blob");

                    // 같은 Room에 있는 다른 클라들한테 채팅 전송
                    if (Program.roomEmps.ContainsKey(p.chats[0].room.id))
                        Program.roomEmps[p.chats[0].room.id]
                            .FindAll(eid => eid != employee.id)
                            .ForEach(eid => {
                                if (Program.clients.ContainsKey(eid))
                                    Program.clients[eid].Send(new ChatsPacket(p.chats[0]));
                            });
                }
                else if(packet.type == PacketType.Schedule)
                {
                    // Panel(Client) -> Client.cs(Server) -> DB add
                    SchedulePacket sp = packet as SchedulePacket;
                    if (Database.AddSchedule(sp.schedules[0]))
                    {
                        Log("Schedule", "스케줄 DB 저장 성공");
                    }
                    else
                        Log("Schedule", "스케줄 DB 저장 실패");
                    
                }

                // 그 외
                else
                {
                    Log("Warning", "Receieved packetType is unknown");
                }
            }

            // Close client
            ns.Close();
            if (socket.Connected) socket.Close();
            Program.RemoveClient(this);
        }
        public void Send(Packet packet)
        {
            lock (this)
            {
                byte[] sendBuffer = AES256.Encrypt(packet.Serialize());
                byte[] lengthBuffer = BitConverter.GetBytes(sendBuffer.Length);

                ns.Write(lengthBuffer, 0, 4);
                ns.Write(sendBuffer, 0, sendBuffer.Length);
                ns.Flush();
            }
        }

        void Log(string type, string content)
        {
            Program.Log(employee.id, type, content);
        }
    }
}
