using MetroFramework.Controls;
using OSTLibrary.Chats;
using OSTLibrary.Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class ControlChat : MetroUserControl
    {
        int verticalSpace;
        public Chat chat;

        public ControlChat(Chat chat, bool continuous)
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

            // 이전 채팅에 연속적일 경우 요소 제거

            Control dataControl = null;
            // 데이터 표시
            if (chat.type == ChatType.Image)
            {
                PictureBox pic = new PictureBox();

                // 디자인 및 이벤트
                pic.Image = chat.image;
                pic.Cursor = Cursors.Hand;
                pic.BackColor = Color.Transparent;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.MouseClick += Pic_Click;

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
                lblTime.Left = Math.Max(pic.Location.X, pic.Location.X + pic.Width - lblTime.Width);

                // 컨트롤 추가 및 제거
                Controls.Remove(lblText);
                Controls.Add(pic);
                dataControl = pic;
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

                    lblTime.Left = Math.Max(lblText.Location.X, lblText.Location.X + lblText.Width - lblTime.Width);
                }
                dataControl = lblText;
            }

            // 연속적일 경우 프로필, 이름을 제거
            // 시계는 다음 채팅이 들어왔을 때 SetContinuous() 호출 되서 제거 됨
            if (continuous || chat.empId == Program.employee.id)
            {
                dataControl.Top = 4;
                Height = dataControl.Top + dataControl.Height + lblTime.Height;

                // 불필요 컨트롤 지우기
                Controls.Remove(picProfile);
                Controls.Remove(lblName);
            }

            // 내가 보낸 것일 경우
            if (chat.empId == Program.employee.id)
            {
                // 데이터 위치
                dataControl.Left = Width - dataControl.Width - Padding.Right;
                dataControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                dataControl.BackColor = Color.LemonChiffon;
                
                // 시계 위치
                lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                lblTime.Left = Math.Min(dataControl.Left, Width - Padding.Right - lblTime.Width);
            }
        }
        
        public void SetContinuous()
        {
            // 다음 채팅 내역이 연속되므로 시간을 지움
            Height -= lblTime.Height;
            Controls.Remove(lblTime);
        }
        public void OwnerRoom_Resize(object sender, EventArgs e)
        {
            Width = (sender as Form).Width - 20;
        }
        private void Pic_Click(object sender, MouseEventArgs e)
        {
            string filename = "OST_" + chat.date.ToString("yyyyMMdd_HHmmss") + ".png";

            if (e.Button == MouseButtons.Left)
            {

                PictureBox pic = sender as PictureBox;
                pic.Image.Save(filename);
                Process.Start(filename);
            }
            else if (e.Button == MouseButtons.Right)
                Process.Start(Environment.CurrentDirectory);
        }
    }
}
