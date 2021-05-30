using Client.Panels;
using MetroFramework.Forms;
using OSTLibrary.Chats;
using OSTLibrary.Networks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormRoom : MetroForm
    {
        ControlChat lastChatCard;

        public Room room;
        public EventHandler onChatAdd;

        public FormRoom(Room room)
        {
            InitializeComponent();
            this.room = room;
        }
        private void FormChat_Load(object sender, EventArgs e)
        {
            if (room.scopeIdx == 0)
                Text = Room.Scope[room.scopeIdx];
            else if (room.scopeIdx == 1)
                Text = Program.employee.central;
            else if (room.scopeIdx == 2)
                Text = Program.employee.team;
            else if (room.scopeIdx == 3)
                Text = Program.employees[room.FindOtherEmployeeId(Program.employee)].name;

            Program.Send(new RoomPacket(room, DateTime.Now));
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            PanelSlider.EnterShadow(sender, e);
        }
        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PanelSlider.LeaveShadow(sender, e);
        }

        private void pnlChat_Scroll(object sender, ScrollEventArgs e)
        {
            // 스크롤 끝까지 올릴 경우 예전 채팅들 요청
        }
        private void picImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp |" +
                "All Files (*.*) | *.*";
            ofd.Title = "사진 선택";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Chat chat = new Chat(ChatType.Image, DateTime.Now, room.id,
                Program.employee.id, Image.FromFile(ofd.FileName));

                AddChatCard(chat);
                Program.Send(new ChatsPacket(chat));

                // 채팅 추가되면 부모가 준 이벤트 처리
                onChatAdd(this, new ChatEventArgs(chat));
            }
        }
        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Shift && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                picSend_Click(sender, new EventArgs());
            }
        }
        private void picSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChat.Text))
                return;

            Chat chat = new Chat(ChatType.Text, DateTime.Now, room.id,
                Program.employee.id, txtChat.Text);

            AddChatCard(chat);
            Program.Send(new ChatsPacket(chat));

            // 채팅 추가되면 부모가 준 이벤트 처리
            onChatAdd(this, new ChatEventArgs(chat));

            txtChat.Text = "";
        }

        public void ReceiveChat(List<Chat> chats)
        {
            Invoke(new MethodInvoker(() => chats.ForEach(c => AddChatCard(c))));

            // 제일 최근 시간 채팅 이벤트로 보내기
            onChatAdd(this, new ChatEventArgs(chats[chats.Count - 1]));
        }
        void AddChatCard(Chat chat)
        {
            // 가장 최근 채팅과 연속적인지 파악
            bool continuous = lastChatCard == null ? false :
                lastChatCard.chat.empId == chat.empId &&
                lastChatCard.chat.date.ToShortDateString() == chat.date.ToShortDateString() &&
                lastChatCard.chat.date.ToShortTimeString() == chat.date.ToShortTimeString();

            // 새로운 채팅 카드 만들고
            ControlChat cc = new ControlChat(chat, continuous);

            // 연속적일 경우 최근 채팅 카드한테 알려주기
            if (continuous)
                lastChatCard.SetContinuous();

            // 새로운 채팅 카드 추가
            Resize += cc.OwnerRoom_Resize;
            pnlChat.Controls.Add(cc);
            pnlChat.VerticalScroll.Value = pnlChat.VerticalScroll.Maximum;

            // 다음을 위해서 가장 최근 채팅 내역 기록
            lastChatCard = cc;
        }
    }

    public class ChatEventArgs : EventArgs
    {
        public Chat chat;
        public ChatEventArgs(Chat chat)
        {
            this.chat = chat;
        }
    }

}
