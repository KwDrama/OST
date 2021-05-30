using Client.Properties;
using MetroFramework.Controls;
using OSTLibrary.Chats;
using OSTLibrary.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class ControlRoomCard : MetroUserControl
    {
        public DateTime dclick;

        public ControlRoomCard(Room room)
        {
            InitializeComponent();

            if (room.scopeIdx == 3)
            {
                Employee otherEmp = Program.employees[room.FindOtherEmployeeId(Program.employee)];
                picProfile.Image = otherEmp.profile;
                lblTitle.Text = otherEmp.name;
                lblTeamRank.Text = otherEmp.team + " " + otherEmp.rank;
            }
            else
            {
                picProfile.Image =
                    room.scopeIdx == 0 ? Resources.office_building :
                    room.scopeIdx == 1 ? Resources.central :
                    room.scopeIdx == 2 ? Resources.team : Resources.profile;

                lblTitle.Text = Room.Scope[room.scopeIdx];

                lblTeamRank.Text =
                    room.scopeIdx == 0 ? "KwDrama" :
                    room.scopeIdx == 1 ? Program.employee.central :
                    room.scopeIdx == 2 ? Program.employee.team : "";
            }
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
            Invoke(new MethodInvoker(() =>
            {
                if (chat.empId == 0)
                {
                    lblChat.Text = "채팅내역 없음";
                    lblTime.Text = "";
                    return;
                }

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
            }));
        }
    }
}
