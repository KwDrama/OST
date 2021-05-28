using Client.Panels;
using MetroFramework.Controls;
using System;

namespace Client.Forms
{
    public partial class ControlRoom : MetroUserControl
    {
        public ControlRoom()
        {
            InitializeComponent();
        }

        private void ControlRoom_MouseEnter(object sender, EventArgs e)
        {
            PanelSlider.EnterShadow(sender, e);
        }

        private void ControlRoom_MouseLeave(object sender, EventArgs e)
        {
            PanelSlider.LeaveShadow(sender, e);
        }
    }
}
