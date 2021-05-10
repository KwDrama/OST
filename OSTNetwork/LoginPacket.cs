using System;

namespace OSTNetwork
{
    [Serializable]
    public class LoginPacket : Packet
    {
        public int empNum;
        public string password;
        public bool success = false;

        public LoginPacket(int empNum, string password)
        {
            Type = PacketType.Login;

            this.empNum = empNum;
            this.password = password;
        }
        public LoginPacket(bool success)
        {
            Type = PacketType.Login;
            this.success = success;
        }
    }
}
