using MetroFramework.Forms;
using OSTNetwork;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormMain : MetroForm
    {
        FormTree formTree;
        FormSchedule formSchedule;

        public FormMain()
        {
            InitializeComponent();
            Opacity = 0;
        }
        private void FormMain_Shown(object sender, System.EventArgs e)
        {
            Hide();
            Opacity = 1;
            if ((new FormLogin()).ShowDialog() == DialogResult.OK)
                Show();
            else
                Close();
        }

        private void pic_Tree_Click(object sender, System.EventArgs e)
        {
            formTree = new FormTree();
            formTree.Location = new Point(500, 300);
            formTree.Show();
        }
        private void pic_Calendar_Click(object sender, System.EventArgs e)
        {
            formSchedule = new FormSchedule();
            formSchedule.Location = new Point(500, 600);
            formSchedule.Show();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show(
                    "메신저를 종료하시겠습니까?",
                    "Caption",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.OK)
                    Close();
            }
        }
    }
}
