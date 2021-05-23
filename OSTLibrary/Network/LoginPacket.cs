using System;

namespace OSTLibrary.Network
{
    [Serializable]
    public class LoginPacket : Packet
    {
        public int empId;
        public string password;
        public bool success = false;

        public LoginPacket(int empId, string password)
        {
            Type = PacketType.Login;

            this.empId = empId;
            this.password = password;
        }
        public LoginPacket(bool success)
        {
            Type = PacketType.Login;
            this.success = success;
        }
    }
}
