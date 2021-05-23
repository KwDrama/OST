using System.Drawing;

namespace OSTLibrary.Chats
{
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
