using System;
using System.Windows.Forms;

namespace Client.Panel
{
    public partial class PanelRegister : PanelSlider
    {
        public PanelRegister(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
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
    }
}
