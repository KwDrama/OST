using OSTLibrary.Chats;
using OSTLibrary.Classes;
using OSTLibrary.Networks;
using OSTLibrary.Securities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client.Forms
{
    static class Program
    {
        public static object locker = new object();                     // 송신 뮤택스
        public static TcpClient client;                                 // 서버와 연결된 TCP 소켓
        public static NetworkStream ns;                                 // 네트워크 스트림
        public static string hostname;                                  // 접속할 서버 주소
        public static readonly ushort port = 6756;                      // 접속할 서버 포트
        public static Thread recvThread;                                // 서버로부터 수신을 대기하는 스레드
        public static Dictionary<PacketType, Action<Packet>> callback;  // 타입에 따른 콜백 메소드

        public static Employee employee;                                // 나의 사원 정보
        public static List<Room> rooms;                                 // 채팅방 정보
        public static List<Schedule> schedules;                         // 스케줄 정보
        public static Dictionary<int, Employee> employees;              // 사원들 정보
        public static FormMain formMain;                                // 적당한 폼 상호작용을 위한 메인폼

        [STAThread]
        static void Main()
        {
            client = new TcpClient();
            recvThread = new Thread(new ThreadStart(Recieve));
            callback = new Dictionary<PacketType, Action<Packet>>();

            string[] args = Environment.GetCommandLineArgs();
            hostname = args.Length > 1 ? args[1] : "127.0.0.1";


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
            byte[] readBuffer = null, lengthBuffer = new byte[4];
            while (client.Connected)
            {
                // 패킷 읽기
                try
                {
                    // 패킷 길이 먼저 읽기
                    if (ns.Read(lengthBuffer, 0, 4) < 4)
                    {
                        formMain.Invoke(new MethodInvoker(() =>
                            MessageBox.Show(formMain, "패킷 길이를 읽지 못하였습니다", "Recieve",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)));

                        // 수신 버퍼 리셋
                        while (ns.ReadByte() != -1) ;
                    }
                    readBuffer = new byte[BitConverter.ToInt32(lengthBuffer, 0)];
                    int position = 0;

                    // 길이를 토대로 데이터 읽기 잘려서 와도 끝까지 읽음
                    while (position < readBuffer.Length)
                        position += ns.Read(readBuffer, position, readBuffer.Length - position);
                }
                catch (ThreadAbortException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    formMain.Invoke(new MethodInvoker(() =>
                        MessageBox.Show(formMain, ex.ToString(), "Recieve",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)));

                    // 패킷 받는 도중 예외가 발생했을 때
                    // 서버와 연결이 종료되었다면 재시작 후 접속 시도
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
                    formMain.Invoke(new MethodInvoker(() =>
                        MessageBox.Show(formMain, ex.ToString(), "Deserialize",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)));

                    // 패킷 받는 도중 예외가 발생했을 때
                    // 서버와 연결이 종료되었다면 재시작 후 접속 시도
                    break;
                }
                if (pakcetObj == null) continue;

                Packet packet = pakcetObj as Packet;

                // 패킷 타입에 따라 호출 가능한 콜백 메서드 실행
                if (callback.ContainsKey(packet.type))
                    callback[packet.type].Invoke(packet);
            }

            Application.Exit();
            Process.Start(Application.ExecutablePath);
        }
        public static void Send(Packet packet)
        {
            lock (locker)
            {
                byte[] sendBuffer = AES256.Encrypt(packet.Serialize());
                byte[] lengthBuffer = BitConverter.GetBytes(sendBuffer.Length);

                ns.Write(lengthBuffer, 0, 4);
                ns.Write(sendBuffer, 0, sendBuffer.Length);
                ns.Flush();
            }
        }
    }
}
