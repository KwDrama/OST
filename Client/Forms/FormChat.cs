using Client.Panels;
using MetroFramework.Forms;
using OSTLibrary.Chats;
using OSTLibrary.Networks;
using System;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormChat : MetroForm
    {
        public Room room;

        public FormChat(Room room)
        {
            InitializeComponent();
            this.room = room;
        }
        private void FormChat_Load(object sender, EventArgs e)
        {
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            PanelSlider.EnterShadow(sender, e);
        }
        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PanelSlider.LeaveShadow(sender, e);
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Shift && e.KeyCode == Keys.Enter)
                picSend_Click(sender, new EventArgs());
        }
        private void picSend_Click(object sender, EventArgs e)
        {
        }

        public void ReceiveChat(ChatsPacket p)
        {

        }
    }
}
