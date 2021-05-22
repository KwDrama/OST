using System;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormChat : MetroFramework.Forms.MetroForm
    {
        public FormChat()
        {
            InitializeComponent();
        }

        private void FormChat_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                var result = MessageBox.Show(
                    "채딩방을 나가시겠습니까?",
                    "Caption",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
