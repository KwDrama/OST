using OSTLibrary.Chats;
using System;

namespace OSTLibrary.Networks
{
    public enum RoomType
    {
        New
    }

    [Serializable]
    public class RoomPacket : Packet
    {
        public RoomType roomType;
        public Room room;

        public RoomPacket(RoomType roomType, Room room)
        {
            type = PacketType.Room;

            this.roomType = roomType;
            this.room = room;
        }
    }
}
