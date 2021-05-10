
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpNum = new MetroFramework.Controls.MetroTextBox();
            this.lnkRegist = new MetroFramework.Controls.MetroLink();
            this.lblSeperate = new MetroFramework.Controls.MetroLink();
            this.spnLogin = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.Checked = true;
            this.chkAutoLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoLogin.Location = new System.Drawing.Point(80, 361);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(83, 15);
            this.chkAutoLogin.TabIndex = 3;
            this.chkAutoLogin.Text = "자동로그인";
            this.chkAutoLogin.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(80, 332);
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
            this.lnkResetPw.Location = new System.Drawing.Point(173, 520);
            this.lnkResetPw.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.lnkResetPw.Name = "lnkResetPw";
            this.lnkResetPw.Size = new System.Drawing.Size(105, 25);
            this.lnkResetPw.TabIndex = 7;
            this.lnkResetPw.Text = "비밀번호 재설정";
            this.lnkResetPw.UseSelectable = true;
            // 
            // lblResult
            // 
            this.lblResult.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblResult.Location = new System.Drawing.Point(80, 419);
            this.lblResult.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 58);
            this.lblResult.TabIndex = 4;
            this.lblResult.UseStyleColors = true;
            this.lblResult.WrapToLine = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Client.Properties.Resources.원인터내셔널_로고;
            this.picLogo.Location = new System.Drawing.Point(80, 68);
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
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
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
            this.txtEmpNum.Location = new System.Drawing.Point(80, 274);
            this.txtEmpNum.MaxLength = 6;
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
            this.txtEmpNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtEmpNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
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
            this.spnLogin.Location = new System.Drawing.Point(169, 332);
            this.spnLogin.Maximum = 100;
            this.spnLogin.Name = "spnLogin";
            this.spnLogin.Size = new System.Drawing.Size(23, 23);
            this.spnLogin.TabIndex = 8;
            this.spnLogin.UseSelectable = true;
            this.spnLogin.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
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
        private MetroFramework.Controls.MetroLink lnkRegist;
        private MetroFramework.Controls.MetroLink lblSeperate;
        private MetroFramework.Controls.MetroProgressSpinner spnLogin;
    }
}