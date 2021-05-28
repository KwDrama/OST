
namespace Client.Forms
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkAutoLogin = new MetroFramework.Controls.MetroCheckBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lnkResetPw = new MetroFramework.Controls.MetroLink();
            this.lblResult = new MetroFramework.Controls.MetroLabel();
            this.lnkRegist = new MetroFramework.Controls.MetroLink();
            this.lblSeperate = new MetroFramework.Controls.MetroLink();
            this.spnLogin = new MetroFramework.Controls.MetroProgressSpinner();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpId = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.Checked = true;
            this.chkAutoLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoLogin.Location = new System.Drawing.Point(80, 365);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(83, 15);
            this.chkAutoLogin.TabIndex = 3;
            this.chkAutoLogin.Text = "자동로그인";
            this.chkAutoLogin.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(80, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 25);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkResetPw
            // 
            this.lnkResetPw.AutoSize = true;
            this.lnkResetPw.Location = new System.Drawing.Point(173, 520);
            this.lnkResetPw.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.lnkResetPw.Name = "lnkResetPw";
            this.lnkResetPw.Size = new System.Drawing.Size(105, 25);
            this.lnkResetPw.TabIndex = 7;
            this.lnkResetPw.Text = "비밀번호 재설정";
            this.lnkResetPw.UseSelectable = true;
            this.lnkResetPw.Click += new System.EventHandler(this.lnkResetPw_Click);
            // 
            // lblResult
            // 
            this.lblResult.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblResult.Location = new System.Drawing.Point(80, 423);
            this.lblResult.Margin = new System.Windows.Forms.Padding(3, 40, 3, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 64);
            this.lblResult.TabIndex = 4;
            this.lblResult.UseStyleColors = true;
            this.lblResult.WrapToLine = true;
            // 
            // lnkRegist
            // 
            this.lnkRegist.AutoSize = true;
            this.lnkRegist.Location = new System.Drawing.Point(82, 520);
            this.lnkRegist.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.lnkRegist.Name = "lnkRegist";
            this.lnkRegist.Size = new System.Drawing.Size(69, 25);
            this.lnkRegist.TabIndex = 5;
            this.lnkRegist.Text = "사원 등록";
            this.lnkRegist.UseSelectable = true;
            this.lnkRegist.Click += new System.EventHandler(this.lnkRegist_Click);
            // 
            // lblSeperate
            // 
            this.lblSeperate.Enabled = false;
            this.lblSeperate.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.lblSeperate.Location = new System.Drawing.Point(157, 520);
            this.lblSeperate.Name = "lblSeperate";
            this.lblSeperate.Size = new System.Drawing.Size(10, 23);
            this.lblSeperate.TabIndex = 6;
            this.lblSeperate.Text = "|";
            this.lblSeperate.UseSelectable = true;
            // 
            // spnLogin
            // 
            this.spnLogin.EnsureVisible = false;
            this.spnLogin.Location = new System.Drawing.Point(168, 334);
            this.spnLogin.Maximum = 100;
            this.spnLogin.Name = "spnLogin";
            this.spnLogin.Size = new System.Drawing.Size(25, 25);
            this.spnLogin.Speed = 2F;
            this.spnLogin.TabIndex = 8;
            this.spnLogin.UseSelectable = true;
            this.spnLogin.Value = 60;
            this.spnLogin.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Client.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(80, 66);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 200);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = global::Client.Properties.Resources.key;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(80, 303);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "비밀번호";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "비밀번호";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // txtEmpId
            // 
            // 
            // 
            // 
            this.txtEmpId.CustomButton.Image = null;
            this.txtEmpId.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtEmpId.CustomButton.Name = "";
            this.txtEmpId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmpId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpId.CustomButton.TabIndex = 1;
            this.txtEmpId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpId.CustomButton.UseSelectable = true;
            this.txtEmpId.CustomButton.Visible = false;
            this.txtEmpId.DisplayIcon = true;
            this.txtEmpId.Icon = global::Client.Properties.Resources.manager;
            this.txtEmpId.Lines = new string[0];
            this.txtEmpId.Location = new System.Drawing.Point(80, 272);
            this.txtEmpId.MaxLength = 6;
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.PasswordChar = '\0';
            this.txtEmpId.PromptText = "사원번호";
            this.txtEmpId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpId.SelectedText = "";
            this.txtEmpId.SelectionLength = 0;
            this.txtEmpId.SelectionStart = 0;
            this.txtEmpId.ShortcutsEnabled = true;
            this.txtEmpId.Size = new System.Drawing.Size(200, 25);
            this.txtEmpId.TabIndex = 0;
            this.txtEmpId.UseSelectable = true;
            this.txtEmpId.WaterMark = "사원번호";
            this.txtEmpId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpId.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.TextChanged += new System.EventHandler(this.txtempId_TextChanged);
            this.txtEmpId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtEmpId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.spnLogin);
            this.Controls.Add(this.lblSeperate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lnkRegist);
            this.Controls.Add(this.lnkResetPw);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkAutoLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmpId);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 38, 20, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "로그인";
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtEmpId;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroCheckBox chkAutoLogin;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLink lnkResetPw;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroLabel lblResult;
        private MetroFramework.Controls.MetroLink lnkRegist;
        private MetroFramework.Controls.MetroLink lblSeperate;
        private MetroFramework.Controls.MetroProgressSpinner spnLogin;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}