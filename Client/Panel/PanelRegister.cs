using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Panel
{
    public partial class PanelRegister : PanelSlider
    {
        Dictionary<string, string[]> organization;

        public PanelRegister(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();

            organization = new Dictionary<string, string[]>();
            organization.Add("자원본부", new string[] { "자원1팀", "자원2팀", "자원3팀" });
            organization.Add("철강본부", new string[] { "철강1팀", "철강2팀", "철강3팀" });
            organization.Add("섬유본부", new string[] { "섬유1팀", "섬유2팀", "섬유3팀" });
            organization.Add("영업본부", new string[] { "영업1팀", "영업2팀", "영업3팀" });
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Swipe(false);
        }

        private void PanelRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Swipe(false);
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            EnterShadow(sender, e);
        }
        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            LeaveShadow(sender, e);
        }

        private void cmbRank1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRank2.Items.AddRange(new string[] { });
        }
    }
}
