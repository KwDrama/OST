using OSTLibrary.Classes;
using System;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class LoginPacket : Packet
    {
        public Employee employee;

        public bool success = false;

        public LoginPacket(int empId, string password)
        {
            type = PacketType.Login;

            employee = new Employee(empId, password);
        }
        public LoginPacket(bool success, Employee employee)
        {
            type = PacketType.Login;
            this.success = success;
            this.employee = employee;
        }
    }
}
