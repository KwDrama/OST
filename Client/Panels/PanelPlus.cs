using System;
using System.Windows.Forms;

namespace Client.Panels
{
    public partial class PanelPlus : PanelSlider
    {
        public PanelPlus(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            EnterShadow(sender, e);
        }
        private void pic_MouseLeave(object sender, EventArgs e)
        {
            LeaveShadow(sender, e);
        }
    }
}
