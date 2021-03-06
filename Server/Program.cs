using OSTLibrary.Classes;
using Server.Classes;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static ushort port = 6756;                              // OST 서버 포트
        static TcpListener listener;                            // 서버 소켓
        static List<Client> unloginedClients;                   // 로그인 전 클라이언트들

        public static Dictionary<int, Client> clients;          // 로그인 후 클라이언트들
        public static Dictionary<int, Employee> employees;      // 사원들 정보
        public static Dictionary<string, List<int>> roomEmps;   // 각 룸에 있는 접속된 사원 번호

        static void Main(string[] args)
        {
            if (args.Length > 0) ushort.TryParse(args[0], out port);

            clients = new Dictionary<int, Client>();
            unloginedClients = new List<Client>();
            roomEmps = new Dictionary<string, List<int>>();

            // 데이터 베이스 접속
            if (Database.Connect())
            {
                Log("DB", $"Server {Database.hostname} is connected");
                if (Database.CreateOfficeRoom())
                    Log("DB", "Office room is created");
                employees = Database.GetEmployees();
            }
            else
            {
                Log("DB", $"Server {Database.hostname} connect failed.");
                return;
            }

            // 테스트

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
        public static void Log(int empId, string type, string content)
        {
            Console.WriteLine(string.Format("[{0}] {1} | {2} | {3}",
                DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"),
                empId, type, content));
        }
        public static void Log(string type, string content)
        {
            Console.WriteLine(string.Format("[{0}] {1} | {2}",
                DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"),
                type, content));
        }

        public static bool MoveLoginClient(Client c)
        {
            if (c.employee.id == 0)
            {
                Log("System", "사원 정보가 없는 클라이언트가 로그인을 했다고 함");
                return false;
            }

            if (clients.ContainsKey(c.employee.id))
                return false;

            clients.Add(c.employee.id, c);
            unloginedClients.Remove(c);
            return true;
        }
        public static void MoveLogoutClient(Client c)
        {
            if (c.employee.id == 0)
            {
                Log("System", "사원 정보가 없는 클라이언트가 로그아웃을 했다고 함");
                return;
            }

            unloginedClients.Add(c);
            clients.Remove(c.employee.id);
        }
        public static void RemoveClient(Client c)
        {
            if (c.employee.id == 0)
                unloginedClients.Remove(c);
            else
                clients.Remove(c.employee.id);
        }
    }
}
