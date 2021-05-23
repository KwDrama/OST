using Client.Panels;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
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
            if ((new FormLogin()).ShowDialog() == DialogResult.OK)
                Show();
            else
                Close();

            foreach (string central in organization.Keys)
            {
                tvwOrganization.Nodes.Add(central, central);
                foreach (string team in organization[central])
                {
                    tvwOrganization.Nodes[central].Nodes.Add(team).ContextMenuStrip = cms;
                }
            }
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
            pnl.Show();
        }
    }
}
