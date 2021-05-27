using System;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class LogoutPacket : Packet
    {
        public LogoutPacket()
        {
            type = PacketType.Logout;
        }
    }
}
