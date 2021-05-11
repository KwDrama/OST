
namespace Client.Panel
{
    partial class PanelRegister
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        #pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroTextBox txtName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelRegister));
            this.cmbRank1 = new MetroFramework.Controls.MetroComboBox();
            this.cmbRank2 = new MetroFramework.Controls.MetroComboBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtRank = new MetroFramework.Controls.MetroTextBox();
            this.txtPwConfirm = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpNum = new MetroFramework.Controls.MetroTextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            txtName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            // 
            // 
            // 
            txtName.CustomButton.Image = null;
            txtName.CustomButton.Location = new System.Drawing.Point(176, 1);
            txtName.CustomButton.Name = "";
            txtName.CustomButton.Size = new System.Drawing.Size(23, 23);
            txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            txtName.CustomButton.TabIndex = 1;
            txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            txtName.CustomButton.UseSelectable = true;
            txtName.CustomButton.Visible = false;
            txtName.DisplayIcon = true;
            txtName.Icon = global::Client.Properties.Resources.user;
            txtName.Lines = new string[0];
            txtName.Location = new System.Drawing.Point(80, 317);
            txtName.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            txtName.MaxLength = 20;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PromptText = "이름";
            txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new System.Drawing.Size(200, 25);
            txtName.TabIndex = 3;
            txtName.UseSelectable = true;
            txtName.WaterMark = "이름";
            txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            txtName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmbRank1
            // 
            this.cmbRank1.FormattingEnabled = true;
            this.cmbRank1.ItemHeight = 23;
            this.cmbRank1.Location = new System.Drawing.Point(80, 406);
            this.cmbRank1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.cmbRank1.Name = "cmbRank1";
            this.cmbRank1.Size = new System.Drawing.Size(97, 29);
            this.cmbRank1.TabIndex = 4;
            this.cmbRank1.UseSelectable = true;
            // 
            // cmbRank2
            // 
            this.cmbRank2.FormattingEnabled = true;
            this.cmbRank2.ItemHeight = 23;
            this.cmbRank2.Location = new System.Drawing.Point(183, 406);
            this.cmbRank2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.cmbRank2.Name = "cmbRank2";
            this.cmbRank2.Size = new System.Drawing.Size(97, 29);
            this.cmbRank2.TabIndex = 4;
            this.cmbRank2.UseSelectable = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(80, 499);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "사원 등록";
            this.btnSubmit.UseSelectable = true;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.DisplayIcon = true;
            this.txtPhone.Icon = ((System.Drawing.Image)(resources.GetObject("txtPhone.Icon")));
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(80, 348);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "전화번호";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(200, 25);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "전화번호";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtRank
            // 
            // 
            // 
            // 
            this.txtRank.CustomButton.Image = null;
            this.txtRank.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtRank.CustomButton.Name = "";
            this.txtRank.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRank.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRank.CustomButton.TabIndex = 1;
            this.txtRank.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRank.CustomButton.UseSelectable = true;
            this.txtRank.CustomButton.Visible = false;
            this.txtRank.DisplayIcon = true;
            this.txtRank.Icon = global::Client.Properties.Resources.star;
            this.txtRank.Lines = new string[0];
            this.txtRank.Location = new System.Drawing.Point(80, 441);
            this.txtRank.MaxLength = 20;
            this.txtRank.Name = "txtRank";
            this.txtRank.PasswordChar = '\0';
            this.txtRank.PromptText = "직위";
            this.txtRank.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRank.SelectedText = "";
            this.txtRank.SelectionLength = 0;
            this.txtRank.SelectionStart = 0;
            this.txtRank.ShortcutsEnabled = true;
            this.txtRank.Size = new System.Drawing.Size(200, 25);
            this.txtRank.TabIndex = 3;
            this.txtRank.UseSelectable = true;
            this.txtRank.WaterMark = "직위";
            this.txtRank.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRank.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPwConfirm
            // 
            // 
            // 
            // 
            this.txtPwConfirm.CustomButton.Image = null;
            this.txtPwConfirm.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtPwConfirm.CustomButton.Name = "";
            this.txtPwConfirm.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPwConfirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPwConfirm.CustomButton.TabIndex = 1;
            this.txtPwConfirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPwConfirm.CustomButton.UseSelectable = true;
            this.txtPwConfirm.CustomButton.Visible = false;
            this.txtPwConfirm.DisplayIcon = true;
            this.txtPwConfirm.Icon = global::Client.Properties.Resources.key;
            this.txtPwConfirm.Lines = new string[0];
            this.txtPwConfirm.Location = new System.Drawing.Point(80, 259);
            this.txtPwConfirm.MaxLength = 20;
            this.txtPwConfirm.Name = "txtPwConfirm";
            this.txtPwConfirm.PasswordChar = '●';
            this.txtPwConfirm.PromptText = "비밀번호 확인";
            this.txtPwConfirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwConfirm.SelectedText = "";
            this.txtPwConfirm.SelectionLength = 0;
            this.txtPwConfirm.SelectionStart = 0;
            this.txtPwConfirm.ShortcutsEnabled = true;
            this.txtPwConfirm.Size = new System.Drawing.Size(200, 25);
            this.txtPwConfirm.TabIndex = 3;
            this.txtPwConfirm.UseSelectable = true;
            this.txtPwConfirm.UseSystemPasswordChar = true;
            this.txtPwConfirm.WaterMark = "비밀번호 확인";
            this.txtPwConfirm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPwConfirm.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtPassword.Location = new System.Drawing.Point(80, 228);
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
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "비밀번호";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtEmpNum
            // 
            // 
            // 
            // 
            this.txtEmpNum.CustomButton.Image = null;
            this.txtEmpNum.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtEmpNum.CustomButton.Name = "";
            this.txtEmpNum.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmpNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpNum.CustomButton.TabIndex = 1;
            this.txtEmpNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpNum.CustomButton.UseSelectable = true;
            this.txtEmpNum.CustomButton.Visible = false;
            this.txtEmpNum.DisplayIcon = true;
            this.txtEmpNum.Icon = global::Client.Properties.Resources.manager;
            this.txtEmpNum.Lines = new string[0];
            this.txtEmpNum.Location = new System.Drawing.Point(80, 197);
            this.txtEmpNum.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.txtEmpNum.MaxLength = 6;
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.PasswordChar = '\0';
            this.txtEmpNum.PromptText = "사원번호";
            this.txtEmpNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpNum.SelectedText = "";
            this.txtEmpNum.SelectionLength = 0;
            this.txtEmpNum.SelectionStart = 0;
            this.txtEmpNum.ShortcutsEnabled = true;
            this.txtEmpNum.Size = new System.Drawing.Size(200, 25);
            this.txtEmpNum.TabIndex = 2;
            this.txtEmpNum.UseSelectable = true;
            this.txtEmpNum.WaterMark = "사원번호";
            this.txtEmpNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpNum.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = global::Client.Properties.Resources.add_user;
            this.picLogo.Location = new System.Drawing.Point(80, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.White;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(319, 3);
            this.picClose.Name = "picClose";
            this.picClose.Padding = new System.Windows.Forms.Padding(10);
            this.picClose.Size = new System.Drawing.Size(36, 36);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // PanelRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbRank2);
            this.Controls.Add(this.cmbRank1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(txtName);
            this.Controls.Add(this.txtPwConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmpNum);
            this.Location = new System.Drawing.Point(0, 30);
            this.Name = "PanelRegister";
            this.Size = new System.Drawing.Size(358, 560);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtEmpNum;
        private MetroFramework.Controls.MetroTextBox txtPwConfirm;
        private MetroFramework.Controls.MetroComboBox cmbRank1;
        private MetroFramework.Controls.MetroTextBox txtRank;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroComboBox cmbRank2;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picClose;
    }
}
