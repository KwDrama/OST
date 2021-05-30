using MetroFramework.Controls;
using OSTLibrary.Chats;
using OSTLibrary.Classes;
using System;
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
                // TODO 라벨 없애고 이미지 컨트롤 추가해서 이미지 넣기
            }
            else
            {
                // 텍스트부터 컨트롤에 넣기
                lblText.Text = chat.text;

                // Resize를 대비해 초기 채팅 여백 측정
                verticalSpace = Height - lblText.Height;

                // 텍스트 사이즈 측정 및 적용
                Graphics g = CreateGraphics();
                SizeF sizef = g.MeasureString(lblText.Text, Font, lblText.Width);

                lblText.Height = (int)sizef.Height;
                Height = lblText.Height + verticalSpace;

                // 한 줄 짜리 텍스트일 경우
                if (sizef.Height < 20)
                {
                    sizef = g.MeasureString(lblText.Text, Font);
                    lblText.Width = (int)sizef.Width + 3;

                    lblTime.Location = new Point(Math.Max(
                        lblText.Location.X, lblText.Location.X + lblText.Width - lblTime.Width),
                        lblTime.Location.Y);
                }
            }
        }
    }
}
