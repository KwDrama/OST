using Client.Panels;
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

            Program.employees.ForEach(emp =>
            {
                if (!tvwOrganization.Nodes.ContainsKey(emp.central))
                    tvwOrganization.Nodes.Add(emp.central, emp.central);
                tvwOrganization.Nodes[emp.central].ImageIndex = -1;
                if (!tvwOrganization.Nodes[emp.central].Nodes.ContainsKey(emp.team))
                    tvwOrganization.Nodes[emp.central].Nodes.Add(emp.team, emp.team);

                tvwOrganization.ImageList.Images.Add(emp.profile);
                TreeNode node = tvwOrganization.Nodes[emp.central].Nodes[emp.team].Nodes.Add(emp.name);

                node.ContextMenuStrip = new MetroContextMenu(components);
                node.ContextMenuStrip.Text = emp.id.ToString();
                ToolStripItem tsiInfo = node.ContextMenuStrip.Items.Add("정보");
                ToolStripItem tsiChat = node.ContextMenuStrip.Items.Add("채팅");
                tsiInfo.Click += (nodeSender, nodeE) => new FormInfo(emp).Show();
                tsiChat.Click += (nodeSender, nodeE) => new FormChat(
                    new Room("", 3, emp.id + "," + Program.employee.id)).Show();

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
    }
}
