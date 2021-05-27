using System.Windows.Forms;
using MetroFramework.Forms;
using OSTLibrary.Classes;

namespace Client.Forms
{
    public partial class FormInfo : MetroForm
    {
        public InfoType type;

        public enum InfoType
        {
            Employee, Central
        }

        public FormInfo(InfoType type, Employee employee)
        {
            InitializeComponent();
            this.type = type;
        }
        //public FormInfo(InfoType type, Central central)
        //{
        //    InitializeComponent();
        //    this.type = type;
        //}
        private void FormInfo_Load(object sender, System.EventArgs e)
        {
            if (type == InfoType.Employee)
            {
                Text = "사원 프로필";
            }
            else
            {
                Text = "본부 정보";
            }
        }

        private void FormInfoPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
