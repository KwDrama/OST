using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Panel
{
    public partial class PanelRegister : PanelSlider
    {
        public PanelRegister(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();
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

        private void PanelRegister_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = CreateGraphics();
            //int x = type == SlidingType.Left ? 0: Width;
            //g.DrawLine(new Pen(Color.FromArgb(109, 109, 109)), x, 0, x, Height);
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            EnterShadow(sender, e);
        }
        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            LeaveShadow(sender, e);
        }
    }
}
