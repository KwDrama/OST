using MetroFramework.Forms;
using OSTNetwork;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormMain : MetroForm
    {
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

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show(
                    "메신저를 종료하시겠습니까?",
                    "Caption",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.OK)
                    this.Close();
            }
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            SetTreeViewData();
        }

        //트리구조 출력(임시, 후에 DB연동해서 불러와 Add할 것)
        public void SetTreeViewData()
        {
            tvw.Nodes.Add("원인터내셔널");

            tvw.Nodes[0].Nodes.Add("자원본부");
            tvw.Nodes[0].Nodes[0].Nodes.Add("자원1팀");
            tvw.Nodes[0].Nodes[0].Nodes.Add("자원2팀");
            tvw.Nodes[0].Nodes[0].Nodes.Add("자원3팀");

            tvw.Nodes[0].Nodes.Add("철강본부");
            tvw.Nodes[0].Nodes[1].Nodes.Add("철강1팀");
            tvw.Nodes[0].Nodes[1].Nodes.Add("철강2팀");
            tvw.Nodes[0].Nodes[1].Nodes.Add("철강3팀");

            tvw.Nodes[0].Nodes.Add("섬유본부");
            tvw.Nodes[0].Nodes[2].Nodes.Add("섬유1팀");
            tvw.Nodes[0].Nodes[2].Nodes.Add("섬유2팀");
            tvw.Nodes[0].Nodes[2].Nodes.Add("섬유3팀");

            tvw.Nodes[0].Nodes.Add("영업본부");
            tvw.Nodes[0].Nodes[3].Nodes.Add("영업1팀");
            tvw.Nodes[0].Nodes[3].Nodes.Add("영업2팀");
            tvw.Nodes[0].Nodes[3].Nodes.Add("영업3팀");

            tvw.ExpandAll();
        }

        //클릭 시 채팅방 이동
        private void mnChat_Click(object sender, System.EventArgs e)
        {
            FormChat formChat = new FormChat();
            formChat.Show();
        }

        private void mnInfo_Click(object sender, System.EventArgs e)
        {

        }
    }
}
