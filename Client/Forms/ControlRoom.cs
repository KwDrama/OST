using Client.Properties;
using MetroFramework.Controls;
using OSTLibrary.Chats;
using System;
using System.Drawing;

namespace Client.Forms
{
    public partial class ControlRoom : MetroUserControl
    {
        public DateTime dclick;

        public ControlRoom(Room room)
        {
            InitializeComponent();

            picProfile.Image =
                room.scopeIdx == 0 ? Resources.office_building :
                room.scopeIdx == 1 ? Resources.central :
                room.scopeIdx == 2 ? Resources.team :
                room.scopeIdx == 3 ? room.GetOtherEmployee(Program.employee).profile :
                Resources.profile;
        }

        private void ControlRoom_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(238, 238, 238);
        }
        private void ControlRoom_MouseLeave(object sender, EventArgs e)
        {
            if (ClientRectangle.Contains(PointToClient(MousePosition)))
                return;
            BackColor = Color.White;
        }

        public void UpdateInfo(Chat chat)
        {
            lblChat.Text =
                chat.type == ChatType.Text ? chat.text :
                chat.type == ChatType.Image ? "사진" : "";

            if (chat.date.Year < DateTime.Now.Year)
                lblTime.Text = $"{DateTime.Now.Year - chat.date.Year}년 전";
            else if (chat.date.Month < DateTime.Now.Month)
                lblTime.Text = $"{DateTime.Now.Month - chat.date.Month}달 전";
            else if (chat.date.Day < DateTime.Now.Day)
                lblTime.Text = $"{DateTime.Now.Month - chat.date.Month}일 전";
            else
                lblTime.Text = chat.date.ToShortTimeString();
        }
    }
}
