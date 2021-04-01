using Client.Classes;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormMain : MetroForm
    {
        Processor proc = Processor.Instance;
        public Employee MyEmp;

        public FormMain()
        {
            InitializeComponent();
            proc.formMain = this;
            (new FormLogin()).ShowDialog();
        }
        private void FormMain_Shown(object sender, System.EventArgs e)
        {

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            proc.Close();
        }
    }
}
