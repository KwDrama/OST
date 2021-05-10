using OSTNetwork;
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
        byte[] sendBuffer;          // 송신 버퍼
        byte[] readBuffer;          // 수신 버퍼
        public Thread recvThread;   // 클라이언트로부터 수신을 대기하는 스레드
        public int empNum;          // 클라이언트의 사원 번호

        public Client(TcpClient socket)
        {
            this.socket = socket;
            ns = socket.GetStream();
            sendBuffer = new byte[Packet.BUFFER_SIZE];
            readBuffer = new byte[Packet.BUFFER_SIZE];

            recvThread = new Thread(new ThreadStart(Recieve));
            recvThread.Start();
        }

        public void Recieve()
        {
            while (true)
            {
                // 패킷 읽기
                try
                {
                    ns.Read(readBuffer, 0, readBuffer.Length);
                }
                catch (IOException socketEx)
                {
                    Log("Disconnect", socketEx.Message);
                    Array.Clear(readBuffer, 0, readBuffer.Length);
                    return;
                }
                catch (Exception ex)
                {
                    Log("Exception", ex.ToString());
                    Array.Clear(readBuffer, 0, readBuffer.Length);
                    return;
                }

                // 패킷 번역
                object pakcetObj = Packet.Deserialize(readBuffer);
                if (pakcetObj == null)
                    return;
                Packet packet = pakcetObj as Packet;
                Array.Clear(readBuffer, 0, readBuffer.Length);

                // 패킷 타입에 따라 진행
                if (packet.Type == PacketType.None)
                {
                    Log("Warning", "Receieved packetType is none");
                }
                else if (packet.Type == PacketType.Login)
                {
                    LoginPacket p = packet as LoginPacket;

                    bool success = Database.Login(p.empNum, p.password);
                    if (success)
                    {
                        empNum = p.empNum;
                        Log("Login", "성공");
                        Program.MoveLoginClient(this);
                    }
                    else
                    {
                        Program.Log("Login", string.Format("{0} 실패", p.empNum));
                    }

                    Thread.Sleep(2000); // 클라이언트 스피너 보기 위함
                    Send(new LoginPacket(success).Serialize());
                    Array.Clear(sendBuffer, 0, sendBuffer.Length);
                }
                else
                {
                    Log("Warning", "Receieved packetType is unknown");
                }
            }
        }

        void Send(byte[] data)
        {
            data.CopyTo(sendBuffer, 0);
            ns.Write(sendBuffer, 0, sendBuffer.Length);
            ns.Flush();
        }
        void Log(string type, string content)
        {
            Program.Log(empNum, type, content);
        }
    }
}
