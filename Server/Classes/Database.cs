using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Server.Classes
{
    static class Database
    {
        public static MySqlConnection con;                      // DB 연결 정보
        public static readonly string hostname = "www.ygh.kr";  // DB 서버 주소
        public static readonly string id = "ost";               // DB 유저 이름
        public static readonly string password = "dr@M@0st";    // DB 비밀 번호
        public static readonly string dbName = "ost";           // DB 기본 데베

        static string Filter(string str)
        {
            return Regex.Replace(str, @"[-<>()'""\;=+|&#.]", "");
        }
        public static bool Connect()
        {
            con = new MySqlConnection(
                string.Format("Server={0};Uid={1};Pwd={2};Database={3}",
                hostname, id, password, dbName));

            try
            {
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Login(int empId, string password)
        {
            string sql = $"SELECT Name FROM employee WHERE id={empId} AND password={Filter(password)}";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            return cmd.ExecuteScalar() != null;
        }
        public static bool Register(Image profile, int empId, string password,
            string name, string phone, string central, string team, string rank)
        {
            // employee 테이블의 id 가 기본키이므로 insert 했을 때 중복 되면 오류를 반환 할거임
            // 그럼 false 반환하면 되고 정상 작동 되었다 하면 true 반환하게 하면 됨

            Program.Log("DB-Register", "empId : " + empId.ToString());
            Program.Log("DB-Register", "password : " + password);
            Program.Log("DB-Register", "name : " + name);
            Program.Log("DB-Register", "phone : " + phone);
            Program.Log("DB-Register", "central : " + central);
            Program.Log("DB-Register", "team : " + team);
            Program.Log("DB-Register", "rank : " + rank);

            throw new NotImplementedException();
        }
        public static void AddSchedule()
        {
            throw new NotImplementedException();
        }
        public static void GetSchedule()
        {
            throw new NotImplementedException();
        }
        public static void AddChatText()
        {
            throw new NotImplementedException();
        }
        public static string[] GetChatText()
        {
            throw new NotImplementedException();
        }
        public static void AddChatBlob(Image image)
        {
            throw new NotImplementedException();
        }
        public static Image GetChatBlob()
        {
            throw new NotImplementedException();
        }
    }
}
