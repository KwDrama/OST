using Server.Classes;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static ushort port = 6756;                  // OST 서버 포트
        static TcpListener listener;                // 서버 소켓
        static Dictionary<int, Client> clients;     // 로그인 후 클라이언트
        static List<Client> unloginedClients;       // 로그인 전 클라이언트

        static void Main(string[] args)
        {
            if (args.Length > 0) ushort.TryParse(args[0], out port);

            clients = new Dictionary<int, Client>();
            unloginedClients = new List<Client>();

            // 데이터 베이스 접속
            if (Database.Connect())
            {
                Log("DB", $"Server {Database.hostname} is connected.");
            }
            else
            {
                Log("DB", $"Server {Database.hostname} connect failed.");
                return;
            }

            // 서버 시작
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            Log("System", $"Server is opend with port {port}");

            // 접속 받기
            while (true)
            {
                Client client = new Client(listener.AcceptTcpClient());
                if (!client.socket.Connected) continue;

                unloginedClients.Add(client);
                Log("Connect", "클라이언트 접속");
            }
        }
        public static void Log(int empNum, string type, string content)
        {
            Console.WriteLine(string.Format("[{0}] {1} | {2} | {3}",
                DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"),
                empNum, type, content));
        }
        public static void Log(string type, string content)
        {
            Console.WriteLine(string.Format("[{0}] {1} | {2}",
                DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"),
                type, content));
        }

        public static void MoveLoginClient(Client c)
        {
            if (c.empNum == 0)
                Log("System", "empNum이 0인 객체가 로그인되었다고 함수를 호출했습니다.");

            clients.Add(c.empNum, c);
            unloginedClients.Remove(c);
        }
        public static void RemoveClient(Client c)
        {
            if (c.empNum == 0)
                unloginedClients.Remove(c);
            else
                clients.Remove(c.empNum);
        }
    }
}
