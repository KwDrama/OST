﻿using Client.Panels;
using MetroFramework.Controls;
using MetroFramework.Forms;
using OSTLibrary.Chats;
using OSTLibrary.Networks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormMain : MetroForm
    {
        List<FormChat> formChats;

        public FormMain()
        {
            InitializeComponent();

            formChats = new List<FormChat>();
            Opacity = 0;
        }
        private void FormMain_Shown(object sender, EventArgs e)
        {
            Hide();
            Opacity = 1;

            FormLogin form = new FormLogin();
            if (form.ShowDialog() == DialogResult.OK) Show();
            else
            {
                Close();
                return;
            }

            picProfile.Image = Program.employee.profile;
            lblName.Text = Program.employee.name;
            lblTeamRank.Text = $"{Program.employee.team} {Program.employee.rank}";

            // 최초 룸 모두 추가
            Program.rooms.ForEach(AddRoomCard);

            // 룸 받기 콜백
            if (!Program.callback.ContainsKey(PacketType.Room))
                Program.callback.Add(PacketType.Room, ReceiveRoom);

            // 챗 받기 콜백
            if (!Program.callback.ContainsKey(PacketType.Chat))
                Program.callback.Add(PacketType.Chat, ReceiveChat);

            // 사원 정보 받고 그에 관한 모든 것 처리
            Program.employees.ForEach(emp =>
            {
                // 본부와 팀 없을 경우 추가
                if (!tvwOrganization.Nodes.ContainsKey(emp.central))
                    tvwOrganization.Nodes.Add(emp.central, emp.central);
                tvwOrganization.Nodes[emp.central].ImageIndex = -1;
                if (!tvwOrganization.Nodes[emp.central].Nodes.ContainsKey(emp.team))
                    tvwOrganization.Nodes[emp.central].Nodes.Add(emp.team, emp.team);

                // 프로필 이미지
                tvwOrganization.ImageList.Images.Add(emp.profile);
                TreeNode node = tvwOrganization.Nodes[emp.central].Nodes[emp.team].Nodes.Add(emp.name);

                // 컨택스트 메뉴
                node.ContextMenuStrip = new MetroContextMenu(components);
                node.ContextMenuStrip.Text = emp.id.ToString();
                ToolStripItem tsiInfo = node.ContextMenuStrip.Items.Add("정보");
                ToolStripItem tsiChat = node.ContextMenuStrip.Items.Add("채팅");

                // 컨택스트 메뉴 이벤트
                tsiInfo.Click += (nodeSender, nodeE) => new FormInfo(emp).Show();

                tsiChat.Click += (nodeSender, nodeE) =>
                {
                    Room room = Program.rooms.Find(r => r.scopeIdx == 3 && r.target.Contains(emp.id.ToString()));
                    formChats.Add(new FormChat(room));

                    if (room == null)
                        Program.Send(new RoomPacket(RoomType.New, room));
                };

                // 이미지 인덱스
                node.ImageIndex = node.SelectedImageIndex =
                    tvwOrganization.ImageList.Images.Count - 1;
            });

            if (tabMenu.SelectedTab.Text == "일정")
                lnkSchAdd.Visible = true;
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            PanelSlider.EnterShadow(sender, e);
        }
        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PanelSlider.LeaveShadow(sender, e);
        }
        private void picProfile_Click(object sender, EventArgs e)
        {
            FormInfo formInfoP = new FormInfo(Program.employee);
            formInfoP.Show();
        }
        private void picLogout_Click(object sender, EventArgs e)
        {
            Program.Send(new Packet(PacketType.Close));
            if (File.Exists("login.txt")) File.Delete("login.txt");
            Application.Exit();
            Process.Start(Application.ExecutablePath);
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lnkSchAdd.Visible = tabMenu.SelectedTab.Text == "일정";
        }
        private void lnkSchAdd_Click(object sender, EventArgs e)
        {
            PanelSchedule pnl = new PanelSchedule(this, SlidingType.Left);
            pnl.Swipe();
        }

        void AddRoomCard(Room room)
        {

        }
        void ReceiveRoom(Packet p)
        {
            RoomPacket rp = p as RoomPacket;

            Program.rooms.Add(rp.room);
            AddRoomCard(rp.room);
            formChats.Find(form => form.room == null).room = rp.room;
        }
        void ReceiveChat(Packet p)
        {
            ChatsPacket cp = p as ChatsPacket;
            formChats.Find(fc => fc.room.id == cp.chats[0].room.id).ReceiveChat(cp);
        }
    }
}
