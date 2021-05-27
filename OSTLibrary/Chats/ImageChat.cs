using System;
using System.Drawing;

namespace OSTLibrary.Chats
{
    [Serializable]
    public class ImageChat : Chat
    {
        public Image image;

        public ImageChat(Image image)
        {
            type = ChatType.Image;
            this.image = image;
        }
    }
}
