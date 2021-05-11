using MySql.Data.MySqlClient;
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
        static string Filter(string str)
        {
            return Regex.Replace(str, @"[-<>()'""\;=+|&#.]", "");
        }
        public static bool Login(int empNum, string password)
        {
            string sql = $"SELECT Name FROM employee WHERE id={empNum} AND password={Filter(password)}";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            return cmd.ExecuteScalar() != null;
        }
    }
}
