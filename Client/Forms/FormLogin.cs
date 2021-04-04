using Client.Classes;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormLogin : MetroForm
    {
        Processor proc = Processor.Instance;
        bool loginable = false, logined = false;

        public FormLogin()
        {
            InitializeComponent();
            proc.formLogin = this;
        }
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            lblResult.Style = MetroFramework.MetroColorStyle.Black;
            lblResult.Text = "기본 서버에 연결 중입니다.";
            proc.Connect("127.0.0.1");
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logined)
                proc.Close();
        }

        private void txtEmpNum_TextChanged(object sender, EventArgs e)
        {
            // 숫자가 아닌 문자들 전부 제거하는 Regex 패턴
            txtEmpNum.Text = Regex.Replace(txtEmpNum.Text, @"\D", "");
            lblResult.Text = "";
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!loginable) return;

            // 빈 항목 있을 경우 입력 요구
            foreach (MetroTextBox mtb in new MetroTextBox[] { txtEmpNum, txtPassword })
                if (string.IsNullOrWhiteSpace(txtEmpNum.Text))
                {
                    mtb.Focus();
                    lblResult.Style = MetroFramework.MetroColorStyle.Red;
                    lblResult.Text = $"{mtb.WaterMark}를 입력해주세요.";
                    return;
                }

            // TODO 프로그래스 스피너 제작하기
            loginable = false;
            lblResult.Style = MetroFramework.MetroColorStyle.Black;
            lblResult.Text = "로그인 중..";

            proc.Login(txtEmpNum.Text, txtPassword.Text);
        }

        public void EndConnect(bool success)
        {
            // 연결 도중 폼을 닫으면 함수 실행 안함
            if (this == null) return;

            Invoke(new MethodInvoker(() =>
            {
                if (loginable = success)
                    lblResult.Text = "";
                else
                {
                    lblResult.Style = MetroFramework.MetroColorStyle.Red;
                    lblResult.Text = "서버 연결 실패했다.\n연결 폼 띄우게 만들어라.";
                }
            }));
        }
        public void EndLogin(bool success)
        {
            if (logined = success)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                Invoke(new MethodInvoker(() =>
                {
                    lblResult.Style = MetroFramework.MetroColorStyle.Red;
                    lblResult.Text = "사원번호 또는 비밀번호를 다시 확인해주세요.";
                }));
            loginable = true;
        }
    }
}
