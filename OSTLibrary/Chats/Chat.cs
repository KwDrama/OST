using System;
using System.Drawing;

namespace OSTLibrary.Chats
{
    public enum ChatType
    {
        Text, Image
    }
    
    [Serializable]
    public class Chat : IComparable<Chat>
    {
        public ChatType type;
        public DateTime date;
        public Room room;
        public int empId;

        // 데이터들
        public Image image;
        public string text;

        public Chat(ChatType type, DateTime date, Room room, int empId, Image image)
        {
            this.type = type;
            this.date = date;
            this.room = room;
            this.empId = empId;
            this.image = image;
        }
        public Chat(ChatType type, DateTime date, Room room, int empId, string text)
        {
            this.type = type;
            this.date = date;
            this.room = room;
            this.empId = empId;
            this.text = text;
        }

        public int CompareTo(Chat other)
            => date.CompareTo(other);
    }
}
