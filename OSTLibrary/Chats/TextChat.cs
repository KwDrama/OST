using System;

namespace OSTLibrary.Chats
{
    [Serializable]
    public class TextChat : Chat
    {
        public string text;

        public TextChat(string text)
        {
            type = ChatType.Text;
            this.text = text;
        }
    }
}
