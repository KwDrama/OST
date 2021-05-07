using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Server.Classes
{
    class AsyncObject
    {
        public Socket socket;
        public Employee emp;
        // 데이터 송수신 상태를 나타냄 이걸로 다음 데이터 받을때 뭘 할건지 판별할 수 있음
        public (string type, int index) state = (string.Empty, 0);
        public byte[] buffer;
        public List<object> memory = new List<object>();

        // 생성자로써 처음에 버퍼 사이즈 받고 버퍼 만듦
        public AsyncObject(int bufferSize = 4096)
        {
            buffer = new byte[bufferSize];
            emp = new Employee("");
        }

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
        // 통신 데이터의 타입 상수 정의
        private readonly List<string> TYPES = new List<string>(new string[] {
            "auth", "chat"
        });

        // 서버 소켓 개방 후 동기로 클라이언트 받기
        public void OpenSocket(int port)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(new IPEndPoint(IPAddress.Any, port));
            server.Listen(10);
            Program.Log("system", "서버 열림", port.ToString());

            while (true)
            {
                Socket client = null;
                // 어떤 클라이언트 요청 수락
                try
                {
                    client = server.Accept();
                    Program.Log("system", "클라 접속",
                        ((IPEndPoint)client.RemoteEndPoint).Address.ToString());
                }
                catch (Exception e)
                {
                    Program.Log("exception-accept", "", e.Message);
                    continue;
                }

                // 데이터 받기 시작
                AsyncObject co = new AsyncObject() { socket = client };
                client.BeginReceive(co.buffer, 0, co.buffer.Length, SocketFlags.None, onReceived, co);

                // 클라이언트 리스트에 추가
                clientList.Add(co);
            }
        }
        public void Close()
        {
            clientList.ForEach(o => o.socket.Close());
            server.Close();
        }

        // 클라이언트 데이터 받기
        private void onReceived(IAsyncResult ar)
        {
            AsyncObject ao = ar.AsyncState as AsyncObject;
            ActionFromReceiving(ao);

            // 버퍼 비워주고 새로운 데이터 또 받는 상태로 대기
            ao.ClearBuffer();
            try
            {
                ao.socket.BeginReceive(ao.buffer, 0, ao.buffer.Length, SocketFlags.None, onReceived, ao);
            }
            // 클라이언트가 종료했을 경우 리스트에서 삭제하고 로깅
            catch (SocketException)
            {
                if (!string.IsNullOrEmpty(ao.emp.num))
                    Program.Log("auth", ao.emp.num, "로그아웃");

                Program.Log("system", "클라 종료",
                    ((IPEndPoint)ao.socket.RemoteEndPoint).Address.ToString());
                ao.socket.Close();
                clientList.Remove(ao);
            }
            catch (Exception e)
            {
                Program.Log("exception-recieve", ao.emp.num, e.Message);
                return;
            }
        }
        private void ActionFromReceiving(AsyncObject ao)
        {
            // 타입과 데이터 판별
            if (string.IsNullOrEmpty(ao.state.type))
            {
                string type = ao.BufferToString();

                if (!string.IsNullOrEmpty(type))
                {
                    // 리스트 중에 있는 타입일 경우 타입 설정하고
                    if (TYPES.Exists(s => s == type))
                        ao.state = (type, 0);
                    // 아닐경우 미분류 그룹에 타입을 로깅
                    else
                        Program.Log(type, ao.emp.num, "Unknown type");
                }
            }
            // 로그인 처리
            else if (ao.state.type == "auth")
            {
                ao.memory.Add(ao.BufferToString());

                if (ao.state.index == 0)
                    ao.state.index++;
                else if (ao.state.index == 1)
                {
                    bool success = ao.memory[0] as string == "1234" && ao.memory[1] as string == "1234";
                    if (success)
                    {
                        Program.Log("auth", ao.emp.num = ao.memory[0] as string, "로그인");
                    }
                    else
                        Program.Log("auth", ao.memory[0] as string, "실패");


                    // 로그인 성공 여부를 클라이언트에게 보내고 해당 클라이언트 상태 초기화
                    ao.socket.Send(new byte[1] { (byte)(success ? 2 : 1) });
                    ao.ClearState();
                    ao.memory.Clear();
                }
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
                        c.socket.Send(Encoding.UTF8.GetBytes(ao.emp.num));
                        c.socket.Send(Encoding.UTF8.GetBytes(text));
                    });

                // 서버에 채팅 로깅 후 클라이언트 상태 초기화
                Program.Log("chat", ao.emp.num, text);
                ao.ClearState();
            }
        }
        //public void MariaDB_SelectTest()
        //{
        //    string connstr = "Server=127.0.0.1;Port=3306;Database=insadb;Uid=root;Pwd=12345678";
        //    MySqlConnection conn = new MySqlConnection(connstr);
        //    MySqlCommand cmd = conn.CreateCommand();

        //    string sql = "Select * from member where id = 1";
        //}
    }
}
