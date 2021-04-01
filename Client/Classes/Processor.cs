using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Client.Classes
{
    class Processor
    {
        // 싱글톤 패턴
        private static readonly Lazy<Processor> _instance
            = new Lazy<Processor>(() => new Processor());
        public static Processor Instance { get { return _instance.Value; } }
        private Processor() { }

        // 네트워크
        Socket server;
        public (string type, int index) state = (string.Empty, 0);
        public byte[] buffer = new byte[4096];
        List<object> memory = new List<object>();
        // 통신 데이터의 타입 상수 정의
        private readonly List<string> TYPES = new List<string>(new string[] {
            "auth", "chat"
        });

        public string BufferToString()
            => Encoding.UTF8.GetString(buffer).Trim('\0');

        // 로깅을 위한 폼 받기 (크로스 스레드 주의)
        public Forms.FormLogin formLogin;
        public Forms.FormMain formMain;

        private void onReceived(IAsyncResult ar)
        {
            int receivedByte;
            try { receivedByte = server.EndReceive(ar); }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (ObjectDisposedException) { return; }

            if (receivedByte <= 0)
            {
                Console.WriteLine("[시스템] 서버와 연결이 끊겼습니다.");
                server.Close();
                return;
            }
            // 받았는데 텅 비어있으면 다시 받기
            if (buffer[0] == 0)
            {
                server.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, onReceived, null);
                return;
            }

            // 타입과 데이터 판별
            if (string.IsNullOrEmpty(state.type))
                state = (BufferToString(), 0);
            // 0과 1로 성공 여부를 받음
            else if (state.type == "auth")
            {
                formLogin.EndLogin(buffer[0] > 1);
                state = (string.Empty, 0);
            }
            // 이름과 내용 총 2번 받옴
            else if (state.type == "chat")
            {
                memory.Add(BufferToString());

                if (state.index == 0)
                    state.index++;
                else if (state.index == 1)
                {
                    Console.WriteLine($"{memory[0]} : {memory[1]}");
                    memory.Clear();
                    state = (string.Empty, 0);
                }
            }

            // 버퍼 지우고 데이터 받는 상태로 대기
            Array.Clear(buffer, 0, buffer.Length);
            server.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, onReceived, null);
        }

        public void Connect(string host = "gcp.ygh.kr", ushort port = 6756)
        {
            if (server == null)
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            if (!server.IsBound)
                server.BeginConnect(host, port, (ar) =>
                {
                    try
                    {
                        server.EndConnect(ar);
                        server.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, onReceived, null);
                        formLogin.EndConnect(true);
                    }
                    catch
                    {
                        formLogin.EndConnect(false);
                    }
                }, null);
        }
        public void Send(string type, params string[] contents)
        {
            Send(Encoding.UTF8.GetBytes(type));
            foreach (string str in contents)
                Send(Encoding.UTF8.GetBytes(str));
        }
        public void Send(byte[] data)
        {
            byte[] sendBuffer = new byte[4096];
            data.CopyTo(sendBuffer, 0);
            server.Send(sendBuffer);
        }
        public void Close()
        {
            server.Close();
        }

        public void Login(string empNum, string password)
        {
            state = ("auth", 0);
            Send(state.type, empNum, password);
        }
    }
}
