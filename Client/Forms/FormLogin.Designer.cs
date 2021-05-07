
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
        private void InitializeComponent()
        {
            this.chkAutoLogin = new MetroFramework.Controls.MetroCheckBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lnkResetPw = new MetroFramework.Controls.MetroLink();
            this.lblResult = new MetroFramework.Controls.MetroLabel();
            this.btnRegist = new MetroFramework.Controls.MetroButton();
            this.lblName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpNum = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.Checked = true;
            this.chkAutoLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoLogin.Location = new System.Drawing.Point(80, 389);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(89, 17);
            this.chkAutoLogin.TabIndex = 3;
            this.chkAutoLogin.Text = "자동로그인";
            this.chkAutoLogin.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(80, 331);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkResetPw
            // 
            this.lnkResetPw.AutoSize = true;
            this.lnkResetPw.Location = new System.Drawing.Point(128, 510);
            this.lnkResetPw.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.lnkResetPw.Name = "lnkResetPw";
            this.lnkResetPw.Size = new System.Drawing.Size(129, 30);
            this.lnkResetPw.TabIndex = 5;
            this.lnkResetPw.Text = "비밀번호 재설정";
            this.lnkResetPw.UseSelectable = true;
            // 
            // lblResult
            // 
            this.lblResult.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblResult.Location = new System.Drawing.Point(80, 407);
            this.lblResult.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 80);
            this.lblResult.TabIndex = 4;
            this.lblResult.UseStyleColors = true;
            this.lblResult.WrapToLine = true;
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(80, 360);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(200, 23);
            this.btnRegist.TabIndex = 7;
            this.btnRegist.Text = "사원 정보 등록";
            this.btnRegist.UseSelectable = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("휴먼엑스포", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(74, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(214, 34);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "원 인터내셔널";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Client.Properties.Resources.원인터내셔널_로고;
            this.picLogo.Location = new System.Drawing.Point(80, 67);
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
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = global::Client.Properties.Resources.key;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(80, 302);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "비밀번호";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "비밀번호";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txt_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtEmpNum
            // 
            // 
            // 
            // 
            this.txtEmpNum.CustomButton.Image = null;
            this.txtEmpNum.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtEmpNum.CustomButton.Name = "";
            this.txtEmpNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpNum.CustomButton.TabIndex = 1;
            this.txtEmpNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpNum.CustomButton.UseSelectable = true;
            this.txtEmpNum.CustomButton.Visible = false;
            this.txtEmpNum.DisplayIcon = true;
            this.txtEmpNum.Icon = global::Client.Properties.Resources.user;
            this.txtEmpNum.Lines = new string[0];
            this.txtEmpNum.Location = new System.Drawing.Point(80, 273);
            this.txtEmpNum.MaxLength = 20;
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.PasswordChar = '\0';
            this.txtEmpNum.PromptText = "사원번호";
            this.txtEmpNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpNum.SelectedText = "";
            this.txtEmpNum.SelectionLength = 0;
            this.txtEmpNum.SelectionStart = 0;
            this.txtEmpNum.ShortcutsEnabled = true;
            this.txtEmpNum.Size = new System.Drawing.Size(200, 23);
            this.txtEmpNum.TabIndex = 0;
            this.txtEmpNum.UseSelectable = true;
            this.txtEmpNum.WaterMark = "사원번호";
            this.txtEmpNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpNum.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNum.TextChanged += new System.EventHandler(this.txtEmpNum_TextChanged);
            this.txtEmpNum.Enter += new System.EventHandler(this.txt_Enter);
            this.txtEmpNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(360, 590);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lnkResetPw);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkAutoLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmpNum);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 38, 20, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtEmpNum;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroCheckBox chkAutoLogin;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLink lnkResetPw;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroLabel lblResult;
        private MetroFramework.Controls.MetroButton btnRegist;
        private System.Windows.Forms.Label lblName;
    }
}