using System;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class LoginPacket : Packet
    {
        public int empId;
        public string password;
        public bool success = false;

        public LoginPacket(int empId, string password)
        {
            type = PacketType.Login;

            this.empId = empId;
            this.password = password;
        }
        public LoginPacket(bool success)
        {
            type = PacketType.Login;
            this.success = success;
        }
    }
}
