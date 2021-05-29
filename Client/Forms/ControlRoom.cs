using MetroFramework.Controls;
using System;
using System.Drawing;

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
            BackColor = Color.FromArgb(238, 238, 238);
        }
        private void ControlRoom_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }
    }
}
