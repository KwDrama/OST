using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class AsyncObject
    {
        public Socket socket;
        public string name = string.Empty;
        // 데이터 송수신 상태를 나타냄 이걸로 다음 데이터 받을때 뭘 할건지 판별할 수 있음
        public (string type, int index) state = (string.Empty, 0);
        public byte[] buffer;

        // 생성자로써 처음에 버퍼 사이즈 받고 버퍼 만듦
        public AsyncObject(int bufferSize = 4096)
            => buffer = new byte[bufferSize];

        public string BufferToString()
            => Encoding.UTF8.GetString(buffer).Trim('\0');

        public void ClearState()
            => state = (string.Empty, 0);
        public void ClearBuffer()
            => Array.Clear(buffer, 0, buffer.Length);
    }

    public class Processor
    {
        // 싱글톤 패턴
        private static readonly Lazy<Processor> _instance
            = new Lazy<Processor>(() => new Processor());
        public static Processor Instance { get { return _instance.Value; } }
        private Processor() { }

        // 서버 소켓
        Socket server;
        // 접속한 클라이언트 리스트
        List<AsyncObject> clientList = new List<AsyncObject>();

        // 로그 함수
        public static Action<string, string, string> Log;

        // FormOpen 에서 연결버튼 누를때 이 함수 최초 한번 실행함으로써 서버 오픈
        public void InitSocket(int port)
        {
            // 서버 소켓 개방 후 비동기로 클라이언트 받기
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(new IPEndPoint(IPAddress.Any, port));
            server.Listen(10);
            server.BeginAccept(onAccept, null);
            Log("system", "서버 열림", port.ToString());
        }
        public void Close()
        {
            clientList.ForEach(o => o.socket.Close());
            server.Close();
        }

        // 클라이언트 접속 받기
        private void onAccept(IAsyncResult ar)
        {
            Socket client = null;
            // 어떤 클라이언트 요청 수락
            try { client = server.EndAccept(ar); }
            catch (ObjectDisposedException) { return; }

            // 다른 클라이언트 요청 대기
            server.BeginAccept(onAccept, null);

            // 데이터 받기 대기
            AsyncObject co = new AsyncObject() { socket = client };
            client.BeginReceive(co.buffer, 0, co.buffer.Length, SocketFlags.None, onReceived, co);

            // 클라이언트 리스트에 추가
            clientList.Add(co);
        }
        // 클라이언트 데이터 받기
        private void onReceived(IAsyncResult ar)
        {
            AsyncObject ao = ar.AsyncState as AsyncObject;

            // 타입과 데이터 판별
            if (string.IsNullOrEmpty(ao.state.type))
            {
                string type = ao.BufferToString();

                if (!string.IsNullOrEmpty(type))
                {
                    // 리스트 중에 있는 타입일 경우 타입 설정하고
                    if (new List<string>(new string[] {
                        "login", "chat"
                    }).Exists(s => s == type))
                        ao.state = (type, 0);
                    // 아닐경우 미분류 그룹에 타입을 로깅
                    else
                        Log(type, ao.name, "Unknown type");
                }

            }
            // 클라이언트가 서버랑 연결되면 최초로 하는 이름 로그인 처리
            else if (ao.state.type == "login")
            {
                string name = Encoding.UTF8.GetString(ao.buffer);
                bool success = !clientList.Exists(o => o.name == name);
                if (success)
                    Log("login", ao.name, "로그인");

                // 로그인 성공 여부를 클라이언트에게 보내고 해당 클라이언트 상태 초기화
                ao.socket.Send(new byte[1] { (byte)(success ? 2 : 1) });
                ao.ClearState();
            }
            // 채팅이 들어오면 다른 사람들한테 메세지 뿌려주기
            else if (ao.state.type == "chat")
            {
                string text = ao.BufferToString();

                // 채팅 보낸 클라이언트를 제외한 모든 클라이언트한테 메세지 뿌리기
                clientList
                    .FindAll(c => c.socket.Handle != ao.socket.Handle)
                    .ForEach(c =>
                    {
                        c.socket.Send(Encoding.UTF8.GetBytes("chat"));
                        c.socket.Send(Encoding.UTF8.GetBytes(ao.name));
                        c.socket.Send(Encoding.UTF8.GetBytes(text));
                    });

                // 서버에 채팅 로깅 후 클라이언트 상태 초기화
                Log("chat", ao.name, text);
                ao.ClearState();
            }

            // 버퍼 비워주고 새로운 데이터 또 받는 상태로 대기
            ao.ClearBuffer();
            try
            {
                ao.socket.BeginReceive(ao.buffer, 0, ao.buffer.Length, SocketFlags.None, onReceived, ao);
            }
            // 클라이언트가 종료했을 경우 리스트에서 삭제하고 로깅
            catch (SocketException)
            {
                if (!string.IsNullOrEmpty(ao.name))
                    Log("login", ao.name, "로그아웃");

                ao.socket.Close();
                clientList.Remove(ao);
            }
            catch (ObjectDisposedException) { return; }
        }
    }
}
