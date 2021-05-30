﻿using Client.Panels;
using MetroFramework.Forms;
using OSTLibrary.Chats;
using OSTLibrary.Networks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormChat : MetroForm
    {
        public Room room;
        public List<Chat> chats;
        public EventHandler ChatAdd;

        public FormChat(Room room)
        {
            InitializeComponent();
            this.room = room;
            chats = new List<Chat>();
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

            pnlChat.Controls.Add(new ControlChat(chat));
            pnlChat.VerticalScroll.Value = pnlChat.VerticalScroll.Maximum;
            Program.Send(new ChatsPacket(chat));

            // 채팅 추가되면 이벤트로 보내기
            ChatAdd(this, new ChatEventArgs(chat));

            txtChat.Text = "";
        }

        public void ReceiveChat(ChatsPacket p)
        {
            // 제일 최근 시간 채팅 이벤트로 보내기
            ChatAdd(this, new ChatEventArgs(p.chats[p.chats.Count - 1]));
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
