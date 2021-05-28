using Client.Panels;
using MetroFramework.Controls;
using MetroFramework.Forms;
using OSTLibrary.Classes;
using OSTLibrary.Networks;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            if (Program.client.Connected)
                loginable = true;
            else
            {
                lblResult.Style = MetroFramework.MetroColorStyle.Blue;
                lblResult.Text = $"기본 서버에 연결 중입니다.\n{Program.hostname}:{Program.port}";
                Program.client.BeginConnect(Program.hostname, Program.port, EndConnect, null);
            }
        }

        private void txtempId_TextChanged(object sender, EventArgs e)
        {
            // 숫자가 아닌 문자들 전부 제거하는 Regex 패턴
            txtEmpId.Text = Regex.Replace(txtEmpId.Text, @"\D", "");
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
            foreach (MetroTextBox mtb in new MetroTextBox[] { txtEmpId, txtPassword })
                if (string.IsNullOrWhiteSpace(mtb.Text))
                {
                    mtb.Focus();
                    lblResult.Style = MetroFramework.MetroColorStyle.Red;
                    lblResult.Text = $"{mtb.WaterMark}를 입력해주세요.";
                    return;
                }

            // 로그인이 끝나면 실행하도록 콜백 메서드 전달
            if (!Program.callback.ContainsKey(PacketType.Login))
                Program.callback.Add(PacketType.Login, EndLogin);

            // 서버가 연결되어 있으면 계정 정보를 서버로 전송하여 로그인 시도
            if (Program.client.Connected)
            {
                spnLogin.Visible = true;
                txtEmpId.Enabled = txtPassword.Enabled =
                    btnLogin.Visible = loginable = false;
                lblResult.Style = MetroFramework.MetroColorStyle.Black;
                lblResult.Text = "로그인 중..";
                Program.employee = new Employee(int.Parse(txtEmpId.Text), string.Empty);
                Program.Send(new LoginPacket(int.Parse(txtEmpId.Text), txtPassword.Text));
            }
            else
            {
                lblResult.Style = MetroFramework.MetroColorStyle.Red;
                lblResult.Text = "서버와 연결 되어있지 않습니다.";
            }

        }
        private void lnkRegist_Click(object sender, EventArgs e)
        {
            PanelRegister pnlRegister = new PanelRegister(this, SlidingType.Left);
            pnlRegister.Show();
            pnlRegister.Swipe();
        }
        private void lnkResetPw_Click(object sender, EventArgs e)
        {
            lblResult.Style = MetroFramework.MetroColorStyle.Black;
            lblResult.Text = "인사팀 또는 프로그램 개발자에게 문의하세요.";
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

            string savedLoginInfo = File.Exists("login.txt") ? File.ReadAllText("login.txt") : "";

            loginable = true;
            Invoke(new MethodInvoker(() =>
            {
                lblResult.Style = Program.client.Connected ?
                    MetroFramework.MetroColorStyle.Black :
                    MetroFramework.MetroColorStyle.Red;
                lblResult.Text = resultText;

                if (savedLoginInfo.Contains("\n"))
                {
                    txtEmpId.Text = savedLoginInfo.Split('\n')[0];
                    txtPassword.Text = savedLoginInfo.Split('\n')[1];
                }
            }));
        }
        public void EndLogin(Packet packet)
        {
            LoginPacket p = packet as LoginPacket;
            if (p.success)
            {
                DialogResult = DialogResult.OK;
                if (chkAutoLogin.Checked)
                    File.WriteAllText("login.txt", txtEmpId.Text + '\n' + txtPassword.Text);
                Program.employee = p.employees.Find(emp => emp.id == Program.employee.id);
                Program.employees = p.employees;
                BeginInvoke(new MethodInvoker(() => Close()));
            }
            else
                Invoke(new MethodInvoker(() =>
                {
                    spnLogin.Visible = false;
                    txtEmpId.Enabled = txtPassword.Enabled =
                        btnLogin.Visible = loginable = true;
                    lblResult.Style = MetroFramework.MetroColorStyle.Red;
                    lblResult.Text = "사원번호 또는 비밀번호를 다시 확인해주세요.";
                    txtPassword.Text = "";
                }));
        }
    }
}
