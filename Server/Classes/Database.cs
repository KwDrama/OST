using MySql.Data.MySqlClient;
using OSTLibrary.Classes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        public static Employee Login(int empId, string password)
        {
            string sql = $"SELECT id, name, phone, central, team, rank, profile, profile_length FROM employee WHERE id={empId} AND password={Filter(password)}";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            using (MySqlDataReader rdr = cmd.ExecuteReader())
                if (rdr.Read())
                {
                    byte[] profileBytes = new byte[rdr.GetInt32("profile_length")];
                    rdr.GetBytes(rdr.GetOrdinal("profile"), 0, profileBytes, 0, profileBytes.Length);

                    using (MemoryStream ms = new MemoryStream(profileBytes))
                        return new Employee(
                            Image.FromStream(ms),
                            rdr.GetInt32("id"),
                            string.Empty,
                            rdr.GetString("name"),
                            rdr.GetString("phone"),
                            rdr.GetString("central"),
                            rdr.GetString("team"),
                            rdr.GetString("rank"));
                }

            return null;
        }
        public static Employee GetEmployee(int empId)
        {
            string sql = $"SELECT id, name, phone, central, team, rank, profile, profile_length FROM employee WHERE id={empId}";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            using (MySqlDataReader rdr = cmd.ExecuteReader())
                if (rdr.Read())
                {
                    byte[] profileBytes = new byte[rdr.GetUInt32("profile_length")];
                    rdr.GetBytes(rdr.GetOrdinal("profile"), 0, profileBytes, 0, profileBytes.Length);

                    using (MemoryStream ms = new MemoryStream(profileBytes))
                        return new Employee(
                            Image.FromStream(ms),
                            rdr.GetInt32("id"),
                            string.Empty,
                            rdr.GetString("name"),
                            rdr.GetString("phone"),
                            rdr.GetString("central"),
                            rdr.GetString("team"),
                            rdr.GetString("rank"));
                }

            return null;
        }
        public static bool Register(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO employee VAULES(" +
                "@id," +
                "@password," +
                "@name," +
                "@phone," +
                "@central," +
                "@team," +
                "@rank," +
                "@profile," +
                "@profile_length);", con);

            using(MemoryStream ms = new MemoryStream())
            {
                employee.profile.Save(ms, ImageFormat.Png);
                MySqlParameter blob = new MySqlParameter("@profile", MySqlDbType.Blob, (int)ms.Length);
                blob.Value = ms.ToArray();

                cmd.Parameters.AddWithValue("@id", employee.id);
                cmd.Parameters.AddWithValue("@password", employee.password);
                cmd.Parameters.AddWithValue("@name", employee.name);
                cmd.Parameters.AddWithValue("@phone", employee.phone);
                cmd.Parameters.AddWithValue("@central", employee.central);
                cmd.Parameters.AddWithValue("@team", employee.team);
                cmd.Parameters.AddWithValue("@rank", employee.rank);
                cmd.Parameters.Add(blob);
                cmd.Parameters.AddWithValue("@profile_length", (int)ms.Length);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static void AddSchedule()
        {
            return;
        }
        public static void GetSchedule()
        {
            return;
        }
        public static void AddChatText()
        {
            return;
        }
        public static string[] GetChatText()
        {
            return null;
        }
        public static void AddChatBlob(Image image)
        {
            return;
        }
        public static Image GetChatBlob()
        {
            return null;
        }
    }
}
