using MetroFramework.Controls;
using OSTLibrary.Chats;
using OSTLibrary.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

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

            // 채팅을 보낸 사원 정보 표시
            Employee emp = Program.employees[chat.empId];
            picProfile.Image = emp.profile;
            lblName.Text = emp.name;

            // 시간 표시
            lblTime.Text = chat.date.ToShortTimeString();

            // Resize를 대비해 초기 채팅 여백 측정
            verticalSpace = Height - lblText.Height;

            // 데이터 표시
            if (chat.type == ChatType.Image)
            {
                PictureBox pic = new PictureBox();

                // 이미지
                pic.Image = chat.image;
                pic.BackColor = Color.Transparent;
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                // 위치 및 크기
                pic.Location = lblText.Location;
                pic.Margin = pic.Padding = new Padding(0);
                pic.MaximumSize = new Size(260, 300);

                double perWidth = (double)pic.MaximumSize.Width / chat.image.Width;
                double perHeight = (double)pic.MaximumSize.Height / chat.image.Height;
                if (perWidth < perHeight && perWidth < 1)   // 가로 비율이 더 큰 경우
                    pic.Size = new Size(pic.MaximumSize.Width, (int)(chat.image.Height * perWidth));
                else if (perHeight < 1)    // 세로 비율이 더 큰 경우
                    pic.Size = new Size((int)(chat.image.Width * perHeight), pic.MaximumSize.Height);
                else
                    pic.Size = chat.image.Size;

                // 전체 높이 지정
                Height = pic.Height + verticalSpace;

                // 시간 라벨 위치
                lblTime.Location = new Point(Math.Max(
                    pic.Location.X, pic.Location.X + pic.Width - lblTime.Width),
                    lblTime.Location.Y);

                // 컨트롤 추가 및 제거
                Controls.Remove(lblText);
                Controls.Add(pic);
            }
            else
            {
                // 텍스트부터 컨트롤에 넣기
                lblText.Text = chat.text;

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
