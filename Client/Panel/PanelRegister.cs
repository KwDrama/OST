using System;
using System.Windows.Forms;

namespace Client.Panel
{
    public partial class PanelRegister : PanelSlider
    {
        public PanelRegister(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Swipe(false);
        }
    }
}
