using Client.Forms;
using System;
using System.Windows.Forms;

namespace Client.Panels
{
    public partial class PanelSchedule : PanelSlider
    {
        public PanelSchedule(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();
        }
        private void PanelSchedule_Load(object sender, EventArgs e)
        {
            cmbRange.Items.AddRange(new string[]
            {
                "사내 전체",
                Program.employee.central,
                Program.employee.team,
                Program.employee.name,
            });
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            EnterShadow(sender, e);
        }
        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            LeaveShadow(sender, e);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Swipe(false);
        }
    }
}