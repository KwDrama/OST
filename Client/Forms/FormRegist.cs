using System;

namespace Client.Forms
{
    public partial class FormRegist : MetroFramework.Forms.MetroForm
    {
        public FormRegist()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
