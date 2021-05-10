using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OSTNetwork
{
    public enum PacketType
    {
        None, Close, Login,
    }

    [Serializable]
    public class Packet
    {
        public const int BUFFER_SIZE = 4096;

        public PacketType Type;

        public Packet()
        {
            Type = PacketType.None;
        }
        public Packet(PacketType type)
        {
            Type = type;
        }

        public byte[] Serialize()
        {
            using (MemoryStream ms = new MemoryStream(BUFFER_SIZE))
            {
                new BinaryFormatter().Serialize(ms, this);
                return ms.ToArray();
            }
        }
        public static byte[] Serialize(object o)
        {
            using (MemoryStream ms = new MemoryStream(BUFFER_SIZE))
            {
                new BinaryFormatter().Serialize(ms, o);
                return ms.ToArray();
            }
        }
        public static object Deserialize(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(BUFFER_SIZE))
            {
                ms.Write(buffer, 0, buffer.Length);
                ms.Position = 0;

                try
                {
                    return new BinaryFormatter().Deserialize(ms);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
