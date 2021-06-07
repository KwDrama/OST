using OSTLibrary.Classes;
using System;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class RegisterPacket : Packet
    {
        public bool success = false;

        public Employee employee;

        public RegisterPacket(bool success)
        {
            type = PacketType.Register;
            this.success = success;
        }

        public RegisterPacket(Employee employee)
        {
            type = PacketType.Register;
            this.employee = employee;
        }
    }
}
