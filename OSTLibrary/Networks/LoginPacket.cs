using OSTLibrary.Classes;
using System;
using System.Collections.Generic;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class LoginPacket : Packet
    {
        public List<Employee> employees;

        public bool success = false;

        public LoginPacket(int empId, string password)
        {
            type = PacketType.Login;

            employees = new List<Employee>();
            employees.Add(new Employee(empId, password));
        }
        public LoginPacket(bool success, List<Employee> employees)
        {
            type = PacketType.Login;

            this.success = success;
            this.employees = employees;
        }
    }
}
