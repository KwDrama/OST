using System;

namespace OSTLibrary.Chats
{
    public enum ChatType
    {
        Text, Image
    }
    
    public abstract class Chat : IComparable<Chat>
    {
        public ChatType type;
        public DateTime date;
        public string roomId;
        public int empId;

        public int CompareTo(Chat other)
            => date.CompareTo(other);
    }
}
