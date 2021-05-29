using MetroFramework.Controls;
using OSTLibrary.Chats;
using OSTLibrary.Classes;
using System.Drawing;

namespace Client.Forms
{
    public partial class ControlChat : MetroUserControl
    {
        Chat chat;
        int verticalSpace;

        public ControlChat(Chat chat)
        {
            InitializeComponent();

            this.chat = chat;

            Employee emp = Program.employees[chat.empId];
            picProfile.Image = emp.profile;
            lblName.Text = emp.name;

            if (chat.type == ChatType.Image)
            {

            }
            else
            {
                // Resize를 대비해 초기 채팅 여백 측정
                verticalSpace = Height - lblText.Height;

                // 텍스트 사이즈 측정 및 적용
                SizeF sizef = CreateGraphics().MeasureString(lblText.Text, Font, lblText.Width);
                lblText.Height = (int)sizef.Height;
                Height = lblText.Height + verticalSpace;
            }
        }
    }
}
