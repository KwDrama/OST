using OSTLibrary.Classes;
using System;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class RegisterPacket : Packet
    {
        public bool success = false;
        public string result;

        public Employee employee;

        public RegisterPacket(bool success, string result = "")
        {
            type = PacketType.Register;
            this.success = success;
            this.result = result;
        }

        public RegisterPacket(Employee employee)
        {
            type = PacketType.Register;
            this.employee = employee;
        }
    }
}
