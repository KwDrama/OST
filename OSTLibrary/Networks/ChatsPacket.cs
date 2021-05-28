using OSTLibrary.Chats;
using System;
using System.Collections.Generic;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class ChatsPacket : Packet
    {
        public List<Chat> chats;

        public ChatsPacket(List<Chat> chats)
        {
            type = PacketType.Chat;
            this.chats = chats;
        }
    }
}
