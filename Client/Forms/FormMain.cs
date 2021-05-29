using Client.Panels;
using MetroFramework.Controls;
using MetroFramework.Forms;
using OSTLibrary.Chats;
using OSTLibrary.Classes;
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
        Dictionary<string, FormChat> formChats;
        Dictionary<string, ControlRoom> controlRooms;

        public FormMain()
        {
            InitializeComponent();
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

            // 채팅 관련 컨트롤들 배열 초기화
            formChats = new Dictionary<string, FormChat>();
            controlRooms = new Dictionary<string, ControlRoom>();

            // 최초 룸 모두 추가
            Program.rooms.ForEach(AddRoomCard);

            // 룸 받기 콜백
            if (!Program.callback.ContainsKey(PacketType.Room))
                Program.callback.Add(PacketType.Room, ReceiveRoom);

            // 챗 받기 콜백
            if (!Program.callback.ContainsKey(PacketType.Chat))
                Program.callback.Add(PacketType.Chat, ReceiveChat);

            // 사원 정보 받고 그에 관한 모든 것 처리
            foreach (Employee emp in Program.employees.Values)
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

                node.ContextMenuStrip.Items.Add("정보").Click +=
                    (nodeSender, nodeE) => new FormInfo(emp).Show();

                node.ContextMenuStrip.Items.Add("채팅").Click +=
                    (nodeSender, nodeE) =>
                    {
                        Room room = Program.rooms.Find(r => r.scopeIdx == 3 && r.target.Contains(emp.id.ToString()));

                        if (room == null)
                        {
                            room = new Room("", 3, $"{Program.employee.id},{emp.id}");
                            AddFormChat(room);
                            Program.Send(new RoomPacket(RoomType.New, room));
                        }
                        else
                        {
                            if (formChats.ContainsKey(room.id))
                            {
                                formChats[room.id].Focus();
                                return;
                            }
                            AddFormChat(room);
                        }

                        formChats[room.id].Show();
                    };

                // 이미지 인덱스
                node.ImageIndex = node.SelectedImageIndex =
                    tvwOrganization.ImageList.Images.Count - 1;
            }

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

        void AddFormChat(Room room)
        {
            FormChat fc = new FormChat(room);
            fc.FormClosed += (sender, e) => formChats.Remove(room.id);

            formChats.Add(room.id, fc);
        }
        void AddRoomCard(Room room)
        {
            ControlRoom cardRoom = new ControlRoom(room);

            // 채팅방이 이미 있을 경우 포커싱 하고 없을 경우 채팅방 폼 생성
            EventHandler showFormChat = (sender, e) =>
            {
                if (formChats.ContainsKey(room.id))
                {
                    formChats[room.id].Focus();
                    return;
                }

                AddFormChat(room);
                formChats[room.id].Show();
            };

            // 채팅방 카드 더블 클릭 또는 메뉴에서 채팅 클릭 시 채팅방 띄우는 이벤트 실행
            cardRoom.DoubleClick += showFormChat;
            cardRoom.ContextMenuStrip = new MetroContextMenu(components);
            cardRoom.ContextMenuStrip.Items.Add("채팅").Click += showFormChat;

            if (room.lastChat == null)
                cardRoom.UpdateInfo(new Chat(ChatType.Text, DateTime.MinValue, room, 0, ""));
            else
                cardRoom.UpdateInfo(room.lastChat);

            pnlChat.Controls.Add(cardRoom);
            controlRooms.Add(room.id, cardRoom);
        }
        void ReceiveRoom(Packet p)
        {
            RoomPacket rp = p as RoomPacket;

            Program.rooms.Add(rp.room);
            Invoke(new MethodInvoker(() => AddRoomCard(rp.room)));

            if (formChats.ContainsKey(""))
            {
                FormChat fc = formChats[""];
                formChats.Remove("");
                fc.room = rp.room;
                formChats.Add(fc.room.id, fc);
            }
        }
        void ReceiveChat(Packet p)
        {
            ChatsPacket cp = p as ChatsPacket;

            if (formChats.ContainsKey(""))
                formChats[cp.chats[0].room.id].ReceiveChat(cp);
        }
    }
}
