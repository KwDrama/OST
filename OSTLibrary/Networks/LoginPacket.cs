using OSTLibrary.Chats;
using OSTLibrary.Classes;
using System;
using System.Collections.Generic;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class LoginPacket : Packet
    {
        public Dictionary<int, Employee> employees;
        public List<Room> rooms;
        public List<Schedule> schedules;

        public bool success = false;

        public LoginPacket(int empId, string password)
        {
            type = PacketType.Login;

            employees = new Dictionary<int, Employee>();
            employees.Add(0, new Employee(empId, password));
        }
        public LoginPacket(bool success, Dictionary<int, Employee> employees, List<Room> rooms, List<Schedule> schedules)
        {
            type = PacketType.Login;

            this.success = success;
            this.employees = employees;
            this.rooms = rooms;
            this.schedules = schedules;
        }
    }
}
