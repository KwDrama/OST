using MetroFramework.Forms;
using MetroFramework.Controls;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OSTNetwork;

namespace Client.Forms
{
    public partial class FormLogin : MetroForm
    {
        bool loginable = false, enableEnter = true;

        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            lblResult.Style = MetroFramework.MetroColorStyle.Blue;
            lblResult.Text = $"기본 서버에 연결 중입니다.\n{Program.hostname}:{Program.port.ToString()}";
            
            Program.client.BeginConnect(Program.hostname, Program.port, EndConnect, null);
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
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && enableEnter)
            {
                enableEnter = false;
                btnLogin.PerformClick();
            }
        }
        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            enableEnter = true;
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

            // 로그인 데이터 서버로 전송
            if (!Program.callback.ContainsKey(PacketType.Login))
                Program.callback.Add(PacketType.Login, EndLogin);

            Program.Send(new LoginPacket(int.Parse(txtEmpNum.Text), txtPassword.Text).Serialize());
        }
        private void btnRegist_Click(object sender, EventArgs e)
        {

        }

        public void EndConnect(IAsyncResult result)
        {
            string resultText = Program.client.Connected ? "" : "기본 서버 연결 실패";
            try
            {
                Program.client.EndConnect(result);
            }
            catch (Exception ex)
            {
                resultText = ex.Message;
            }

            // 연결 도중 폼을 닫으면 함수 실행 안함
            if (this == null) return;

            if (Program.client.Connected)
            {
                Program.ns = Program.client.GetStream();
                Program.recvThread.Start();
            }

            loginable = true;
            Invoke(new MethodInvoker(() =>
            {
                if (!Program.client.Connected)
                    lblResult.Style = MetroFramework.MetroColorStyle.Red;
                lblResult.Text = resultText;
            }));
        }
        public void EndLogin(Packet packet)
        {
            if ((packet as LoginPacket).success)
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
