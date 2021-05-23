using OSTLibrary.Chats;
using System;
using System.Collections.Generic;

namespace OSTLibrary.Networks
{
    [Serializable]
    public class ChatsPacket : Packet
    {
        public List<Chat> chat;

        public ChatsPacket(List<Chat> chat)
        {
            type = PacketType.Chat;
            this.chat = chat;
        }
    }
}
