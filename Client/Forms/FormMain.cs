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
        Dictionary<string, FormRoom> formChats;             // 켜져있는 채팅방들
        Dictionary<string, ControlRoomCard> roomCards;      // 나의 채팅방 카드들
        Dictionary<string, ControlSchedule> scheduleCards;  //나의 스케줄 카드들

        public FormMain()
        {
            InitializeComponent();
            Opacity = 0;
        }
        private void FormMain_Shown(object sender, EventArgs e)
        {
            Hide();
            Opacity = 1;

            // 다른 내가 접속 시 중복 로그인 발생으로 나 종료
            if (!Program.callback.ContainsKey(PacketType.Room))
                Program.callback.Add(PacketType.DuplicateLogin, p => {
                    File.WriteAllText("DuplicateLogin", "");
                    Program.Send(new Packet(PacketType.Close));
                    Application.Exit();
                    Process.Start(Application.ExecutablePath);
                });

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
            formChats = new Dictionary<string, FormRoom>();
            roomCards = new Dictionary<string, ControlRoomCard>();

            // 최초 룸 모두 추가
            Program.rooms.ForEach(AddRoomCard);

            // 룸 받기 콜백
            if (!Program.callback.ContainsKey(PacketType.Room))
                Program.callback.Add(PacketType.Room, ReceiveRoom);

            // 챗 받기 콜백
            if (!Program.callback.ContainsKey(PacketType.Chat))
                Program.callback.Add(PacketType.Chat, ReceiveChat);

            // 사원 정보 받고 트리뷰 처리
            foreach (Employee emp in Program.employees.Values)
            {
                TreeNode node;

                // 본부 노드 없을 경우 추가
                if (!tvwOrganization.Nodes.ContainsKey(emp.central))
                {
                    tvwOrganization.Nodes.Add(emp.central, emp.central);
                    node = tvwOrganization.Nodes[emp.central];

                    // 본부 노드 컨택스트 메뉴
                    if (node.Text == Program.employee.central)
                    {
                        node.ContextMenuStrip = new MetroContextMenu(components);
                        node.ContextMenuStrip.Items.Add("채팅").Click +=
                            (nodeSender, nodeE) =>
                            {
                                Room room = Program.rooms.Find(r => r.scopeIdx == 1 && r.target.Contains(emp.central));

                                if (room == null)
                                {
                                    room = new Room("", 1, emp.central);
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
                    }
                }

                // 팀 노드 없을 경우 추가
                if (!tvwOrganization.Nodes[emp.central].Nodes.ContainsKey(emp.team))
                {
                    tvwOrganization.Nodes[emp.central].Nodes.Add(emp.team, emp.team);
                    node = tvwOrganization.Nodes[emp.central].Nodes[emp.team];

                    // 팀 노드 컨택스트 메뉴
                    if (node.Text == Program.employee.team)
                    {
                        node.ContextMenuStrip = new MetroContextMenu(components);
                        node.ContextMenuStrip.Items.Add("채팅").Click +=
                            (nodeSender, nodeE) =>
                            {
                                Room room = Program.rooms.Find(r => r.scopeIdx == 2 && r.target.Contains(emp.team));

                                if (room == null)
                                {
                                    room = new Room("", 2, emp.team);
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
                    }
                }

                // 사원 노드 프로필 이미지 아이콘으로 추가
                tvwOrganization.ImageList.Images.Add(emp.profile);
                node = tvwOrganization.Nodes[emp.central].Nodes[emp.team].Nodes.Add(emp.name);

                // 사원 노드 컨택스트 메뉴
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

                // 사원 노드 아이콘
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
            FormRoom fc = new FormRoom(room);
            fc.FormClosed += (sender, e) => formChats.Remove(room.id);
            fc.onChatAdd += (sender, e) => {
                ChatEventArgs args = e as ChatEventArgs;
                roomCards[args.roomId].UpdateInfo(args.chat);
            };

            formChats.Add(room.id, fc);
        }
        void AddRoomCard(Room room)
        {
            ControlRoomCard cardRoom = new ControlRoomCard(room);

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

            // 최근 채팅 존재 유무에 따른 표시
            if (room.lastChat == null)
                cardRoom.UpdateInfo(new Chat(ChatType.Text, DateTime.MinValue, room, 0, ""));
            else
                cardRoom.UpdateInfo(room.lastChat);

            // 채팅 카드 추가
            pnlChat.Controls.Add(cardRoom);
            roomCards.Add(room.id, cardRoom);
        }
        void AddScheduleCard(Schedule schedule)
        {
            ControlSchedule Cschedule = new ControlSchedule(schedule);

            
        }
        void ReceiveRoom(Packet p)
        {
            RoomPacket rp = p as RoomPacket;

            Program.rooms.Add(rp.room);
            Invoke(new MethodInvoker(() => AddRoomCard(rp.room)));

            // 처음 룸이 만들어 졌을 경우 id가 비어있는 룸이 추가가 되었을 것이다
            // 서버가 룸을 중복을 피한id로 룸을 만들어 보내줬으니 그걸 토대로 룸을 다시 Map에 저장
            if (formChats.ContainsKey(""))
            {
                FormRoom fc = formChats[""];
                formChats.Remove("");
                fc.room = rp.room;
                formChats.Add(fc.room.id, fc);
            }
        }
        void ReceiveChat(Packet p)
        {
            ChatsPacket cp = p as ChatsPacket;
            if (cp.chats.Count == 0) return;

            // 채팅 패킷을 받으면 해당 룸이 켜져있을 경우 해당 룸으로 채팅들을 넘겨줌
            if (formChats.ContainsKey(cp.chats[0].room.id))
                formChats[cp.chats[0].room.id].ReceiveChat(cp.chats);

            // 해당 룸이 안켜져 있을 경우 카드만 업데이트 한다
            // 이때 카드도 없을 경우 생성 한다
            else
            {
                if (roomCards.ContainsKey(cp.chats[0].room.id))
                    roomCards[cp.chats[0].room.id].UpdateInfo(cp.chats[cp.chats.Count - 1]);
                else
                {
                    cp.chats[0].room.lastChat = cp.chats[0];
                    Invoke(new MethodInvoker(() => AddRoomCard(cp.chats[0].room)));
                }
            }
        }
        void ReceiveSchedule(Packet p)
        {
            SchedulePacket sp = p as SchedulePacket;

            Program.schedules.Add(sp.schedule);
        }
    }
}
