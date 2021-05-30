using OSTLibrary.Chats;
using System;

namespace OSTLibrary.Networks
{
    public enum RoomType
    {
        New,    // 최초 룸 생성
        Chats   // 채팅 내역 요청
    }

    [Serializable]
    public class RoomPacket : Packet
    {
        public RoomType roomType;
        public Room room;
        public DateTime until;

        public RoomPacket(RoomType roomType, Room room)
        {
            type = PacketType.Room;

            this.roomType = roomType;
            this.room = room;
        }

        // 채팅들 요청
        public RoomPacket(Room room, DateTime until)
        {
            type = PacketType.Room;
            roomType = RoomType.Chats;

            this.room = room;
            this.until = until;
        }
    }
}
