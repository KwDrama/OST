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

            PictureBox pic = null;
            // 데이터 표시
            if (chat.type == ChatType.Image)
            {
                pic = new PictureBox();

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

            // 내가 보낸 것일 경우
            if (chat.empId == Program.employee.id)
            {
                // 전체 높이에 대한 Offset 다시 지정
                int needSubstractheight = lblName.Height + lblName.Margin.Bottom;
                verticalSpace -= needSubstractheight;

                // 데이터 위치
                if (chat.type == ChatType.Image)
                {
                    // 우측 정렬 후 lblName 높이만큼 위로 올리기
                    pic.Location = new Point(Width - Padding.Right - pic.Width, pic.Location.Y - needSubstractheight);
                    pic.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                    // 전체 높이 지정
                    Height = pic.Height + verticalSpace;
                }
                else
                {
                    // 우측 정렬 후 lblName 높이만큼 위로 올리기
                    lblText.Location = new Point(Width - Padding.Right - lblText.Width, lblText.Location.Y - needSubstractheight);
                    lblText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    lblText.BackColor = Color.LemonChiffon;

                    // 전체 높이 지정
                    Height = lblText.Height + verticalSpace;
                }

                // 시계 위치
                lblTime.TextAlign = ContentAlignment.TopLeft;
                lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                lblTime.Location = new Point(Math.Min(
                    chat.type == ChatType.Image ? pic.Location.X : lblText.Location.X,
                    Width - Padding.Right - lblTime.Width),
                    lblTime.Location.Y);

                // 불필요 컨트롤 지우기
                Controls.Remove(picProfile);
                Controls.Remove(lblName);
            }
            else
            {
                // 다른 사람이 보낸 것이 연속적일 경우
                if (continuous)
                {
                    // 전체 높이에 대한 Offset 다시 지정
                    int needSubstractheight = lblName.Height + lblName.Margin.Bottom;
                    verticalSpace -= needSubstractheight;

                    // 데이터 위치
                    if (chat.type == ChatType.Image)
                    {
                        // 우측 정렬 후 lblName 높이만큼 위로 올리기
                        pic.Location = new Point(pic.Location.X, pic.Location.Y - needSubstractheight);

                        // 전체 높이 지정
                        Height = pic.Height + verticalSpace;
                    }
                    else
                    {
                        // 우측 정렬 후 lblName 높이만큼 위로 올리기
                        lblText.Location = new Point(lblText.Location.X, lblText.Location.Y - needSubstractheight);

                        // 전체 높이 지정
                        Height = lblText.Height + verticalSpace;
                    }



                    // 불필요 컨트롤 지우기
                    Controls.Remove(picProfile);
                    Controls.Remove(lblName);
                }
            }

            // 연속될 경우 패딩 제거
            if (continuous)
            {
                int needSubstractHeight = Padding.Top - 4;

                Height -= needSubstractHeight;
                Padding = new Padding(Padding.Left, 4, Padding.Right, Padding.Bottom);
            }

            BackColor = Color.FromArgb(new Random(DateTime.Now.Millisecond).Next());
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
    }
}
