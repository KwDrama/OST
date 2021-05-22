using OSTNetwork;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client.Forms
{
    static class Program
    {
        public static TcpClient client;                                 // 서버와 연결된 TCP 소켓
        public static NetworkStream ns;                                 // 네트워크 스트림
        public static readonly string hostname = "127.0.0.1";           // 접속할 서버 주소
        public static readonly ushort port = 6756;                      // 접속할 서버 포트
        public static Thread recvThread;                                // 서버로부터 수신을 대기하는 스레드
        public static int empNum = 0;                                   // 나의 사원 번호
        public static Dictionary<PacketType, Action<Packet>> callback;  // 타입에 따른 콜백 메소드
        public static FormMain formMain;                                // 적당한 폼 상호작용을 위한 메인폼

        [STAThread]
        static void Main()
        {
            client = new TcpClient();
            recvThread = new Thread(new ThreadStart(Recieve));
            callback = new Dictionary<PacketType, Action<Packet>>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(formMain = new FormMain());

            // 프로그램이 종료되면 서버 연결 끊기
            if (client.Connected)
            {
                Send(new Packet(PacketType.Close));
                if (recvThread.IsAlive)
                    recvThread.Abort();
                client.Close();
            }
        }

        static void Recieve()
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
                catch (ThreadAbortException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(formMain, ex.Message, "Recieve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Array.Clear(readBuffer, 0, readBuffer.Length);
                    return;
                }

                // 큰 버퍼 읽었으면 다시 버퍼 크기 원상 복귀
                if (readLength > Packet.BUFFER_SIZE)
                    readLength = Packet.BUFFER_SIZE;

                // 패킷 번역
                object pakcetObj = Packet.Deserialize(readBuffer);
                if (pakcetObj == null) continue;
                Packet packet = pakcetObj as Packet;

                // 패킷 길이가 클 경우 큰 데이터를 받기
                if (packet.Length > 0)
                {
                    readLength = packet.Length;
                    continue;
                }
                Array.Clear(readBuffer, 0, readBuffer.Length);

                // 패킷 타입에 따라 호출 가능한 콜백 메서드 실행
                if (callback.ContainsKey(packet.Type))
                    callback[packet.Type].Invoke(packet);
            }
        }
        public static void Send(Packet packet)
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
}
