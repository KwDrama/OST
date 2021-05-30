using Client.Panels;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using OSTLibrary.Classes;
using OSTLibrary.Networks;
using OSTLibrary.Securities;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormLogin : MetroForm
    {
        bool loginable = false, enableEnter = true, isAutoLogin = false;

        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            // 중복 로그인 처리
            bool duplicateLogin = File.Exists("DuplicateLogin");
            File.Delete("DuplicateLogin");

            if (duplicateLogin &&
                MetroMessageBox.Show(this,
                "다른 곳에서 내 계정으로 접속하여 로그아웃 되었습니다.\n"
                + "다시 로그인 하시겠습니까?", "중복 로그인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                DialogResult.Yes)
                File.Delete("login.txt");

            if (Program.client.Connected)
                loginable = true;
            else
            {
                lblResult.Style = MetroFramework.MetroColorStyle.Blue;
                lblResult.Text = $"서버에 연결 중입니다.\n{Program.hostname}:{Program.port}";
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

                string EncryptedPassword = isAutoLogin ? txtPassword.Text : SHA512.Encrypt(txtPassword.Text);

                Program.employee = new Employee(int.Parse(txtEmpId.Text), EncryptedPassword);
                Program.Send(new LoginPacket(int.Parse(txtEmpId.Text), EncryptedPassword));
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
                resultText = "서버와 연결되었습니다.";
            }
            else
                resultText += "\n5초 뒤 연결을 재시도 합니다.";

            // 로그인 정보가 저장되어 있을경우 불러오기
            string savedLoginInfo = File.Exists("login.txt") ? File.ReadAllText("login.txt") : "";

            loginable = true;
            Invoke(new MethodInvoker(() =>
            {
                lblResult.Style = Program.client.Connected ?
                    MetroFramework.MetroColorStyle.Green :
                    MetroFramework.MetroColorStyle.Red;
                lblResult.Text = resultText;

                if (savedLoginInfo.Contains("\n"))
                {
                    txtEmpId.Text = savedLoginInfo.Split('\n')[0];
                    txtPassword.Text = savedLoginInfo.Split('\n')[1];
                    isAutoLogin = true;
                    btnLogin.PerformClick();
                }
            }));

            if (!string.IsNullOrEmpty(resultText))
            {
                Thread.Sleep(5000);
                FormLogin_Shown(null, new EventArgs());
            }
        }
        public void EndLogin(Packet packet)
        {
            LoginPacket p = packet as LoginPacket;
            if (p.success)
            {
                DialogResult = DialogResult.OK;

                // 자동 로그인일 경우 로그인 정보를 저장
                if (chkAutoLogin.Checked)
                    File.WriteAllText("login.txt", Program.employee.id + "\n" + Program.employee.password);

                // 받은 로그인 패킷에서 내 사원 정보 찾기
                foreach (Employee emp in p.employees.Values)
                    if (emp.id == Program.employee.id)
                    {
                        Program.employee = emp;
                        break;
                    }

                // 나에 대한 채팅방 정보들과 다른 사원들의 정보를 저장
                Program.rooms = p.rooms;
                Program.employees = p.employees;

                // 로그인 창 닫기
                BeginInvoke(new MethodInvoker(() => Close()));
            }
            else
                Invoke(new MethodInvoker(() =>
                {
                    spnLogin.Visible = false;
                    txtEmpId.Enabled = txtPassword.Enabled =
                        btnLogin.Visible = loginable = true;
                    txtPassword.Text = "";
                    lblResult.Style = MetroFramework.MetroColorStyle.Red;
                    lblResult.Text = "사원번호 또는 비밀번호를 다시 확인해주세요.";
                }));
        }
    }
}
