
namespace Client.Panels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelRegister));
            this.cmbCentral = new MetroFramework.Controls.MetroComboBox();
            this.cmbTeam = new MetroFramework.Controls.MetroComboBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtRank = new MetroFramework.Controls.MetroTextBox();
            this.txtPwConfirm = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtempId = new MetroFramework.Controls.MetroTextBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.tleSubmit = new MetroFramework.Controls.MetroTile();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblCentral = new MetroFramework.Controls.MetroLabel();
            this.lblTeam = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCentral
            // 
            this.cmbCentral.FormattingEnabled = true;
            this.cmbCentral.ItemHeight = 23;
            this.cmbCentral.Location = new System.Drawing.Point(80, 398);
            this.cmbCentral.Name = "cmbCentral";
            this.cmbCentral.Size = new System.Drawing.Size(97, 29);
            this.cmbCentral.TabIndex = 5;
            this.cmbCentral.UseSelectable = true;
            this.cmbCentral.SelectedIndexChanged += new System.EventHandler(this.cmbCentral_SelectedIndexChanged);
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.ItemHeight = 23;
            this.cmbTeam.Location = new System.Drawing.Point(183, 398);
            this.cmbTeam.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(97, 29);
            this.cmbTeam.TabIndex = 6;
            this.cmbTeam.UseSelectable = true;
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
            this.txtPhone.Location = new System.Drawing.Point(80, 342);
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
            this.txtPhone.TabIndex = 4;
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
            this.txtRank.Location = new System.Drawing.Point(80, 433);
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
            this.txtRank.TabIndex = 7;
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
            this.txtPwConfirm.Location = new System.Drawing.Point(80, 253);
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
            this.txtPwConfirm.TabIndex = 2;
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
            this.txtPassword.Location = new System.Drawing.Point(80, 222);
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
            // 
            // txtempId
            // 
            // 
            // 
            // 
            this.txtempId.CustomButton.Image = null;
            this.txtempId.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtempId.CustomButton.Name = "";
            this.txtempId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtempId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtempId.CustomButton.TabIndex = 1;
            this.txtempId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtempId.CustomButton.UseSelectable = true;
            this.txtempId.CustomButton.Visible = false;
            this.txtempId.DisplayIcon = true;
            this.txtempId.Icon = global::Client.Properties.Resources.manager;
            this.txtempId.Lines = new string[0];
            this.txtempId.Location = new System.Drawing.Point(80, 191);
            this.txtempId.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.txtempId.MaxLength = 6;
            this.txtempId.Name = "txtempId";
            this.txtempId.PasswordChar = '\0';
            this.txtempId.PromptText = "사원번호";
            this.txtempId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtempId.SelectedText = "";
            this.txtempId.SelectionLength = 0;
            this.txtempId.SelectionStart = 0;
            this.txtempId.ShortcutsEnabled = true;
            this.txtempId.Size = new System.Drawing.Size(200, 25);
            this.txtempId.TabIndex = 0;
            this.txtempId.UseSelectable = true;
            this.txtempId.WaterMark = "사원번호";
            this.txtempId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtempId.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.White;
            this.picProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProfile.Image = global::Client.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(116, 30);
            this.picProfile.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(128, 128);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 6;
            this.picProfile.TabStop = false;
            this.picProfile.Click += new System.EventHandler(this.picProfile_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.White;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(321, 3);
            this.picClose.Name = "picClose";
            this.picClose.Padding = new System.Windows.Forms.Padding(10);
            this.picClose.Size = new System.Drawing.Size(36, 36);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // tleSubmit
            // 
            this.tleSubmit.ActiveControl = null;
            this.tleSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tleSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tleSubmit.Location = new System.Drawing.Point(0, 522);
            this.tleSubmit.Name = "tleSubmit";
            this.tleSubmit.Size = new System.Drawing.Size(360, 48);
            this.tleSubmit.TabIndex = 8;
            this.tleSubmit.Text = "사원 등록";
            this.tleSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tleSubmit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tleSubmit.UseSelectable = true;
            this.tleSubmit.Click += new System.EventHandler(this.tleSubmit_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.Icon = global::Client.Properties.Resources.user;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(80, 313);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "이름";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "이름";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            // 
            // lblCentral
            // 
            this.lblCentral.AutoSize = true;
            this.lblCentral.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCentral.Location = new System.Drawing.Point(80, 380);
            this.lblCentral.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCentral.Name = "lblCentral";
            this.lblCentral.Size = new System.Drawing.Size(31, 15);
            this.lblCentral.TabIndex = 0;
            this.lblCentral.Text = "본부";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTeam.Location = new System.Drawing.Point(183, 380);
            this.lblTeam.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(19, 15);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "팀";
            // 
            // PanelRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblCentral);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.tleSubmit);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.cmbCentral);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtPwConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtempId);
            this.Location = new System.Drawing.Point(0, 30);
            this.Name = "PanelRegister";
            this.Size = new System.Drawing.Size(360, 570);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtempId;
        private MetroFramework.Controls.MetroTextBox txtPwConfirm;
        private MetroFramework.Controls.MetroComboBox cmbCentral;
        private MetroFramework.Controls.MetroTextBox txtRank;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroComboBox cmbTeam;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.PictureBox picClose;
        private MetroFramework.Controls.MetroTile tleSubmit;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblCentral;
        private MetroFramework.Controls.MetroLabel lblTeam;
    }
}
