using Client.Panels;
using MetroFramework.Forms;
using OSTLibrary.Networks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormMain : MetroForm
    {
        public static Dictionary<string, string[]> organization;

        public FormMain()
        {
            InitializeComponent();
            Opacity = 0;

            organization = new Dictionary<string, string[]>();
            organization.Add("자원본부", new string[] { "자원1팀", "자원2팀", "자원3팀" });
            organization.Add("철강본부", new string[] { "철강1팀", "철강2팀", "철강3팀" });
            organization.Add("섬유본부", new string[] { "섬유1팀", "섬유2팀", "섬유3팀" });
            organization.Add("영업본부", new string[] { "영업1팀", "영업2팀", "영업3팀" });
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

            foreach (string central in organization.Keys)
            {
                tvwOrganization.Nodes.Add(central, central).ContextMenuStrip = cms;
                foreach (string team in organization[central])
                    tvwOrganization.Nodes[central].Nodes.Add(team).ContextMenuStrip = cms;
            }
        }

        private void picLogout_MouseEnter(object sender, EventArgs e)
            => PanelSlider.EnterShadow(sender, e);
        private void picLogout_MouseLeave(object sender, EventArgs e)
            => PanelSlider.LeaveShadow(sender, e);
        private void picLogout_Click(object sender, EventArgs e)
        {
            Program.Send(new Packet(PacketType.Close));
            Application.Exit();
            Process.Start(Application.ExecutablePath);
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lnkSchAdd.Visible = tabMenu.SelectedTab.Text == "일정";
        }
        private void tsmiInfo_Click(object sender, EventArgs e)
        {

        }
        private void tsmiChat_Click(object sender, EventArgs e)
        {
            FormChat formChat = new FormChat();
            formChat.Show();
        }
        private void lnkSchAdd_Click(object sender, EventArgs e)
        {
            PanelSchedule pnl = new PanelSchedule(this, SlidingType.Left);
            pnl.Swipe();
        }
    }
}
