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

        public string BufferToString()
            => Encoding.UTF8.GetString(buffer).Trim('\0');

        // 로깅을 위한 폼 받기 (크로스 스레드 주의)
        public Forms.FormLogin loginer;
        public Forms.FormMain drawer;

        public void Connect(string host, int port, string name)
        {
            if (server == null)
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            if (!server.IsBound)
            {
                server.Connect(host, port);
                server.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, onReceived, null);
            }

            state = ("login", 0);
            Send("login", name);
        }
        public void Close()
        {
            server.Close();
        }
        // contents 의 각 문자열의 크기는 4096 바이트 이하여야 한다.
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

        private void onReceived(IAsyncResult ar)
        {
            int receivedByte;
            try { receivedByte = server.EndReceive(ar); }
            catch (SocketException e)
            {
                drawer.Log(e.Message);
                return;
            }
            catch (ObjectDisposedException) { return; }

            if (receivedByte <= 0)
            {
                server.Close();
                if (drawer != null)
                    drawer.Log("[시스템] 서버와 연결이 끊겼습니다.");
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
            else if (state.type == "login")
            {
                loginer.EndLogin(buffer[0] > 1);
                state = (string.Empty, 0);
            }
            // 이름과 내용 총 2번 받옴
            else if (state.type == "chat")
            {
                memory.Add(BufferToString());

                if (state.index == 0) state.index++;
                else if (state.index == 1)
                {
                    drawer.Log($"{memory[0]} : {memory[1]}");
                    memory.Clear();
                    state = (string.Empty, 0);
                }
            }

            // 버퍼 지우고 데이터 받는 상태로 대기
            Array.Clear(buffer, 0, buffer.Length);
            server.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, onReceived, null);
        }
    }
}
