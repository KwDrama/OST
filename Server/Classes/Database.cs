﻿using MySql.Data.MySqlClient;
using OSTLibrary.Classes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System;
using OSTLibrary.Chats;
using System.Collections.Generic;

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
                catch (MySqlException)
                {
                    return false;
                }
            }
        }

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
            catch (MySqlException)
            {
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
            catch (MySqlException)
            {
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
        public static void AddChat(Chat chat)
        {
        }
        public static List<Chat> GetChats(DateTime begin, DateTime end)
        {
            return null;
        }
    }
}
