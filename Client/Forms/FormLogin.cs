using MetroFramework.Forms;
using System;
using System.Text.RegularExpressions;

namespace Client.Forms
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpNum_TextChanged(object sender, EventArgs e)
        {
            // 숫자가 아닌 문자들 전부 제거하는 Regex 패턴
            txtEmpNum.Text = Regex.Replace(txtEmpNum.Text, @"\D", "");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
