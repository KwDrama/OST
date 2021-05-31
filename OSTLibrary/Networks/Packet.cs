using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OSTLibrary.Networks
{
    public enum PacketType
    {
        Header, Close,                              // 연결
        Login, DuplicateLogin, Logout, Register,    // 로그인
        Chat, Room,                                 // 채팅
    }

    [Serializable]
    public class Packet
    {
        public const int BUFFER_SIZE = 4096;

        public PacketType type;


        public Packet() { }
        public Packet(PacketType type)
        {
            this.type = type;
        }

        public byte[] Serialize() => Serialize(this);
        public static byte[] Serialize(object o)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, o);
                return ms.ToArray();
            }
        }
        public static object Deserialize(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer, 0, buffer.Length))
                return new BinaryFormatter().Deserialize(ms);
        }
    }
}
