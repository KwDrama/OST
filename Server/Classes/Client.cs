using OSTLibrary.Network;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Server.Classes
{
    public class Client
    {
        public TcpClient socket;    // 클라이언트 소켓
        NetworkStream ns;           // 네트워크 스트림
        public Thread recvThread;   // 클라이언트로부터 수신을 대기하는 스레드
        public int empId;           // 클라이언트의 사원 번호

        public Client(TcpClient socket)
        {
            this.socket = socket;
            ns = socket.GetStream();

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
                if (packet.Type == PacketType.Header)
                {
                    Log("Warning", "Receieved packetType is header");
                }
                if (packet.Type == PacketType.Close)
                {
                    Log("Close", "Disconnect client");
                    socket.Close();
                    break;
                }
                else if (packet.Type == PacketType.Login)
                {
                    LoginPacket p = packet as LoginPacket;

                    bool success = Database.Login(p.empId, p.password);
                    if (success)
                    {
                        empId = p.empId;
                        Log("Login", "성공");
                        Program.MoveLoginClient(this);
                    }
                    else
                    {
                        Log("Login", string.Format("{0} 실패", p.empId));
                    }

                    Thread.Sleep(200);  // 클라이언트 스피너 보기 위함
                    Send(new LoginPacket(success));
                }
                else if (packet.Type == PacketType.Register)
                {
                    RegisterPacket p = packet as RegisterPacket;
                    p.profile.Save("profile.png");
                    Log("Test", "Id: " + p.empId.ToString());
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
        void Send(Packet packet)
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
        void Log(string type, string content)
        {
            Program.Log(empId, type, content);
        }
    }
}
