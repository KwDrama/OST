using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Client.Forms
{
    public partial class FormInfoPeople : MetroForm
    {
        public FormInfoPeople()
        {
            InitializeComponent();
        }

        private void FormInfoPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
