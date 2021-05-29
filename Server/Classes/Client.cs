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
        object locker = new object();       // For lock

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
            byte[] readBuffer = new byte[Packet.BUFFER_SIZE];
            int readLength = Packet.BUFFER_SIZE;
            while (true)
            {
                // 읽어야 하는 길이가 버퍼 사이즈랑 다를 경우
                if (readLength != readBuffer.Length)
                    readBuffer = new byte[readLength];

                // 패킷 읽기
                try
                {
                    ns.Read(readBuffer, 0, readBuffer.Length);
                }
                catch (IOException socketEx)
                {
                    Log("IOException", socketEx.Message);
                    Array.Clear(readBuffer, 0, readBuffer.Length);
                    break;
                }
                catch (Exception ex)
                {
                    Log("Exception", ex.ToString());
                    Array.Clear(readBuffer, 0, readBuffer.Length);
                    break;
                }

                // 큰 버퍼 읽었으면 다시 버퍼 크기 원상 복귀
                if (readLength > Packet.BUFFER_SIZE)
                    readLength = Packet.BUFFER_SIZE;

                // 패킷 번역
                object pakcetObj = Packet.Deserialize(readBuffer);
                if (pakcetObj == null)
                {
                    Log("Warning", "Cannot deserialize packet");
                    Array.Clear(readBuffer, 0, readBuffer.Length);
                    break;
                }
                Packet packet = pakcetObj as Packet;
                Array.Clear(readBuffer, 0, readBuffer.Length);

                // 패킷 타입에 따라 진행
                if (packet.type == PacketType.Header)
                {
                    if (packet.Length == 0)
                        Log("Warning", "Receieved no length HeaderPacket");
                    else
                        readLength = packet.Length;
                }
                else if (packet.type == PacketType.Close)
                {
                    Log("Close", "Disconnect client");
                    socket.Close();
                    break;
                }
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
                        Log("Login", "로그인 성공");
                        Program.MoveLoginClient(this);

                        // 로그인 하면서 불러온 사원의 룸 정보를 모두 룸과 사원 관계의 Map에 저장
                        List<Room> myRooms = Database.GetRooms(emp);
                        foreach (Room room in myRooms)
                            if (Program.roomEmps.ContainsKey(room.id))
                                Program.roomEmps[room.id].Add(employee.id);
                            else
                                Program.roomEmps.Add(room.id, new List<int>(new int[] { employee.id }));

                        p = new LoginPacket(true, Program.employees, myRooms);
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
                    if (Database.Register(p.employee))
                    {
                        Program.employees.Add(p.employee.id, employee = p.employee);
                        Log("Register", "회원가입 성공");
                    }
                    else
                        Log("Register", "회원가입 실패");
                }
                else if (packet.type == PacketType.Room)
                {
                    RoomPacket p = packet as RoomPacket;
                    if (p.roomType == RoomType.New)
                    {
                        do p.room.id = MD5.NextRandom();
                        while (!Database.AddRoom(p.room));
                        Send(p);

                        if (p.room.scopeIdx == 3)
                        {

                            int otherEmpId = p.room.FindOtherEmployeeId(employee);
                            if (Program.employees.ContainsKey(otherEmpId))
                            {
                                Employee targetEmp = Program.employees[p.room.FindOtherEmployeeId(employee)];
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
                    }
                }
                else if (packet.type == PacketType.Chat)
                {
                    ChatsPacket p = packet as ChatsPacket;
                    if (p.chats.Count == 0) continue;

                    // 클라한테 받은 채팅 내역 DB에 저장
                    if (Database.AddChat(p.chats[0]))
                        Log("Chat",
                            p.chats[0].type == ChatType.Text ? p.chats[0].text :
                            p.chats[0].type == ChatType.Image ? "사진" : "Blob");
                    else
                        Log("Chat", "채팅 내역 DB 저장 실패");

                    // 같은 Room에 있는 다른 클라들한테 채팅 전송
                    if (Program.roomEmps.ContainsKey(p.chats[0].roomId))
                        Program.roomEmps[p.chats[0].roomId]
                            .FindAll(eid => eid != employee.id)
                            .ForEach(eid => {
                                if (Program.clients.ContainsKey(eid))
                                    Program.clients[eid].Send(new ChatsPacket(p.chats[0]));
                            });
                }
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
            lock (locker)
            {
                byte[] sendBuffer = new byte[Packet.BUFFER_SIZE];
                byte[] packetBytes = packet.Serialize();

                // 기존 버퍼 크기보다 클 경우 (이미지 등)
                if (packetBytes.Length > Packet.BUFFER_SIZE)
                {
                    new Packet(packetBytes.Length).Serialize().CopyTo(sendBuffer, 0);
                    ns.Write(sendBuffer, 0, sendBuffer.Length);
                    ns.Write(packetBytes, 0, packetBytes.Length);
                }
                else
                {
                    packetBytes.CopyTo(sendBuffer, 0);
                    ns.Write(sendBuffer, 0, sendBuffer.Length);
                }

                ns.Flush();
            }
        }
        void Log(string type, string content)
        {
            Program.Log(employee.id, type, content);
        }
    }
}
