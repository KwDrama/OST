using Client.Panels;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormChat : MetroForm
    {
        public FormChat()
        {
            InitializeComponent();
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            PanelSlider.EnterShadow(sender, e);
        }
        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PanelSlider.LeaveShadow(sender, e);
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Shift && e.KeyCode == Keys.Enter)
                picSend_Click(sender, new EventArgs());
        }
        private void picSend_Click(object sender, EventArgs e)
        {

        }
    }
}
