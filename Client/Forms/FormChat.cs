using System;

namespace Client.Forms
{
    public partial class FormChat : MetroFramework.Forms.MetroForm
    {
        public FormChat()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
