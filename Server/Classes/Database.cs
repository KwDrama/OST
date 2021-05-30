using MySql.Data.MySqlClient;
using OSTLibrary.Classes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System;
using OSTLibrary.Chats;
using System.Collections.Generic;
using System.Text;

namespace Server.Classes
{
    static class Database
    {
        public static MySqlConnection con;                      // DB 연결 정보
        public static readonly string hostname = "www.ygh.kr";  // DB 서버 주소
        public static readonly string id = "ost";               // DB 유저 이름
        public static readonly string password = "dr@M@0st";    // DB 비밀 번호
        public static readonly string dbName = "ost";           // DB 기본 데베

        // 필터 및 연결
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

        // 사원
        public static Dictionary<int, Employee> GetEmployees()
        {
            string sql = $"SELECT id, name, phone, central, team, rank, profile, profile_length FROM employee";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            using (MySqlDataReader rdr = cmd.ExecuteReader())
                while (rdr.Read())
                {
                    byte[] profileBytes = new byte[rdr.GetUInt32("profile_length")];
                    rdr.GetBytes(rdr.GetOrdinal("profile"), 0, profileBytes, 0, profileBytes.Length);

                    using (MemoryStream ms = new MemoryStream(profileBytes))
                        employees.Add(rdr.GetInt32("id"), new Employee(
                            Image.FromStream(ms),
                            rdr.GetInt32("id"),
                            string.Empty,
                            rdr.GetString("name"),
                            rdr.GetString("phone"),
                            rdr.GetString("central"),
                            rdr.GetString("team"),
                            rdr.GetString("rank")));
                }

            return employees;
        }
        public static Employee Login(int empId, string password)
        {
            string sql = $"SELECT id, name, phone, central, team, rank, profile, profile_length FROM employee WHERE id={empId} AND password='{Filter(password)}'";
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
        public static bool Register(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO employee VALUES (@id, @password, @name, @phone, @central, @team, @rank, @profile, @profile_length);",
                con);

            using(MemoryStream ms = new MemoryStream())
            {
                employee.profile.Save(ms, ImageFormat.Png);
                MySqlParameter blob = new MySqlParameter("@profile", MySqlDbType.LongBlob, (int)ms.Length);
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

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException e)
                {
                    Program.Log("DB", e.ToString());
                    return false;
                }
            }
        }

        // 일정
        public static bool AddSchedule(Schedule schedule)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO schedule VALUES (@author, @title, @start, @end, @scope, @contents);",
                con);
            using(MemoryStream ms = new MemoryStream())
            {
                MySqlParameter start = new MySqlParameter("@start", MySqlDbType.DateTime, (int)ms.Length);
                MySqlParameter end = new MySqlParameter("@start", MySqlDbType.DateTime, (int)ms.Length);
                MySqlParameter contents = new MySqlParameter("@start", MySqlDbType.LongText, (int)ms.Length);
                start.Value = ms.ToArray(); // MetroDateTime 연결할 것
                end.Value = ms.ToArray(); // MetroDateTime 연결할 것
                end.Value = ms.ToArray();

                cmd.Parameters.AddWithValue("@author", schedule.author);
                cmd.Parameters.AddWithValue("@title", schedule.title);
                cmd.Parameters.Add(start);
                cmd.Parameters.Add(end);
                cmd.Parameters.AddWithValue("@scope", schedule.scope);
                cmd.Parameters.Add(contents);
            }
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                Program.Log("DB", e.ToString());
                return false;
            }
        }
        public static Schedule GetSchedule(int authorID)
        {
            string sql = $"SELECT author, title, start, end, scope, contents FROM employee WHERE id={authorID}";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    using (MemoryStream ms = new MemoryStream())
                        return new Schedule(
                            rdr.GetInt32("author"),
                            rdr.GetString("scope"),
                            rdr.GetDateTime("start"),
                            rdr.GetDateTime("end"),
                            rdr.GetInt32("scope"),
                            rdr.GetString("contents"));
                }
            }
            return null;
            
        }

        // 채팅
        public static bool AddRoom(Room room)
        {
            MySqlCommand cmd = new MySqlCommand(
                   "INSERT INTO room VALUES (@id, @scope, @target);",
                   con);

            cmd.Parameters.AddWithValue("@id", room.id);
            cmd.Parameters.AddWithValue("@scope", room.scopeIdx);
            cmd.Parameters.AddWithValue("@target", room.target);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                Program.Log("DB", e.ToString());
                return false;
            }
        }
        public static List<Room> GetRooms(Employee emp)
        {
            List<Room> rooms = new List<Room>();

            string sql =
                $"(SELECT * FROM room WHERE scope=0)" +
                $" UNION (SELECT * FROM room WHERE scope=1 AND target='{Filter(emp.central)}')" +
                $" UNION (SELECT * FROM room WHERE scope=2 AND target='{Filter(emp.team)}')" +
                $" UNION (SELECT * FROM room WHERE scope=3 AND target LIKE '%{emp.id}%')";

            using (MySqlDataReader rdr = new MySqlCommand(sql, con).ExecuteReader())
                while (rdr.Read())
                    rooms.Add(new Room(rdr.GetString("id"), rdr.GetInt32("scope"), rdr.GetString("target")));

            return rooms;
        }
        public static bool AddChat(Chat chat)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO chat VALUES (@room_id, @chat_date, @employee_id, @data, @data_length, @data_type);",
                con);

            using (MemoryStream ms = new MemoryStream())
            {
                cmd.Parameters.AddWithValue("@room_id", chat.roomId);
                cmd.Parameters.AddWithValue("@chat_date", chat.date);
                cmd.Parameters.AddWithValue("@employee_id", chat.empId);

                // 데이터 byte[]로 만들어서 sql에 집어넣기
                if (chat.type == ChatType.Image)
                {
                    chat.image.Save(ms, ImageFormat.Png);
                    cmd.Parameters.Add(new MySqlParameter("@data", MySqlDbType.LongBlob, (int)ms.Length))
                        .Value = ms.ToArray();
                    cmd.Parameters.AddWithValue("@data_length", (int)ms.Length);
                }
                else
                {
                    byte[] textBytes = Encoding.UTF8.GetBytes(chat.text);
                    cmd.Parameters.Add(new MySqlParameter("@data", MySqlDbType.LongBlob, textBytes.Length))
                        .Value = textBytes;
                    cmd.Parameters.AddWithValue("@data_length", textBytes.Length);
                }
                cmd.Parameters.AddWithValue("@data_type", chat.type);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException e)
                {
                    Program.Log("DB", e.ToString());
                    return false;
                }
            }
        }
        public static Chat GetLastChat(Room room)
        {
            MySqlCommand cmd = new MySqlCommand(
                $"SELECT * FROM chat WHERE room_id='{Filter(room.id)}' ORDER BY chat_date DESC LIMIT 1",
                con);

            using (MySqlDataReader rdr = cmd.ExecuteReader())
                if (rdr.Read())
                {
                    ChatType ct = (ChatType)rdr.GetInt32("data_type");
                    byte[] dataBytes = new byte[rdr.GetInt32("data_length")];
                    rdr.GetBytes(rdr.GetOrdinal("data"), 0, dataBytes, 0, dataBytes.Length);

                    Chat chat = new Chat(ct, rdr.GetDateTime("chat_date"), rdr.GetString("room_id"),
                        rdr.GetInt32("employee_id"), "");

                    if (ct == ChatType.Image)
                        using (MemoryStream ms = new MemoryStream())
                            chat.image = Image.FromStream(ms);
                    else
                        chat.text = Encoding.UTF8.GetString(dataBytes);

                    return chat;
                }
            return null;
        }
        public static List<Chat> GetChats(Room room, DateTime until)
        {
            List<Chat> chats = new List<Chat>();
            MySqlCommand cmd = new MySqlCommand(
                $"SELECT * FROM chat WHERE room_id='{Filter(room.id)}'"
                + "AND chat_date < @chat_date_until LIMIT 100",
                con);
            cmd.Parameters.AddWithValue("@chat_date_until", until);

            using (MySqlDataReader rdr = cmd.ExecuteReader())
                while (rdr.Read())
                {
                    ChatType ct = (ChatType)rdr.GetInt32("data_type");
                    byte[] dataBytes = new byte[rdr.GetInt32("data_length")];
                    rdr.GetBytes(rdr.GetOrdinal("data"), 0, dataBytes, 0, dataBytes.Length);

                    Chat chat = new Chat(ct, rdr.GetDateTime("chat_date"), rdr.GetString("room_id"),
                        rdr.GetInt32("employee_id"), "");

                    if (ct == ChatType.Image)
                        using (MemoryStream ms = new MemoryStream())
                            chat.image = Image.FromStream(ms);
                    else
                        chat.text = Encoding.UTF8.GetString(dataBytes);

                    chats.Add(chat);
                }
            return chats;
        }
    }
}
