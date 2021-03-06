
namespace Client.Forms
{
    partial class FormMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        #pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabMenu = new MetroFramework.Controls.MetroTabControl();
            this.tpOrganization = new MetroFramework.Controls.MetroTabPage();
            this.txtOrgSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tvwOrganization = new System.Windows.Forms.TreeView();
            this.ilistEmployee = new System.Windows.Forms.ImageList(this.components);
            this.tpChat = new MetroFramework.Controls.MetroTabPage();
            this.pnlChat = new System.Windows.Forms.FlowLayoutPanel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lnkSchAdd = new MetroFramework.Controls.MetroLink();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblTeamRank = new MetroFramework.Controls.MetroLabel();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.pnlSchedule = new System.Windows.Forms.FlowLayoutPanel();
            this.tpSchedule = new MetroFramework.Controls.MetroTabPage();
            this.tabMenu.SuspendLayout();
            this.tpOrganization.SuspendLayout();
            this.tpChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.tpSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Controls.Add(this.tpOrganization);
            this.tabMenu.Controls.Add(this.tpSchedule);
            this.tabMenu.Controls.Add(this.tpChat);
            this.tabMenu.Location = new System.Drawing.Point(6, 83);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 1;
            this.tabMenu.Size = new System.Drawing.Size(348, 511);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.UseSelectable = true;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // tpOrganization
            // 
            this.tpOrganization.Controls.Add(this.txtOrgSearch);
            this.tpOrganization.Controls.Add(this.txtSearch);
            this.tpOrganization.Controls.Add(this.tvwOrganization);
            this.tpOrganization.HorizontalScrollbarBarColor = true;
            this.tpOrganization.HorizontalScrollbarHighlightOnWheel = false;
            this.tpOrganization.HorizontalScrollbarSize = 2;
            this.tpOrganization.Location = new System.Drawing.Point(4, 38);
            this.tpOrganization.Name = "tpOrganization";
            this.tpOrganization.Size = new System.Drawing.Size(340, 469);
            this.tpOrganization.TabIndex = 1;
            this.tpOrganization.Text = "조직도";
            this.tpOrganization.VerticalScrollbarBarColor = true;
            this.tpOrganization.VerticalScrollbarHighlightOnWheel = false;
            this.tpOrganization.VerticalScrollbarSize = 11;
            // 
            // txtOrgSearch
            // 
            // 
            // 
            // 
            this.txtOrgSearch.CustomButton.Image = null;
            this.txtOrgSearch.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.txtOrgSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrgSearch.CustomButton.Name = "";
            this.txtOrgSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOrgSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrgSearch.CustomButton.TabIndex = 1;
            this.txtOrgSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrgSearch.CustomButton.UseSelectable = true;
            this.txtOrgSearch.CustomButton.Visible = false;
            this.txtOrgSearch.DisplayIcon = true;
            this.txtOrgSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOrgSearch.Icon = global::Client.Properties.Resources.search;
            this.txtOrgSearch.Lines = new string[0];
            this.txtOrgSearch.Location = new System.Drawing.Point(0, 0);
            this.txtOrgSearch.MaxLength = 32767;
            this.txtOrgSearch.Name = "txtOrgSearch";
            this.txtOrgSearch.PasswordChar = '\0';
            this.txtOrgSearch.PromptText = "부서명 또는 사원이름으로 검색";
            this.txtOrgSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrgSearch.SelectedText = "";
            this.txtOrgSearch.SelectionLength = 0;
            this.txtOrgSearch.SelectionStart = 0;
            this.txtOrgSearch.ShortcutsEnabled = true;
            this.txtOrgSearch.Size = new System.Drawing.Size(340, 25);
            this.txtOrgSearch.TabIndex = 3;
            this.txtOrgSearch.UseSelectable = true;
            this.txtOrgSearch.WaterMark = "부서명 또는 사원이름으로 검색";
            this.txtOrgSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrgSearch.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(0, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tvwOrganization
            // 
            this.tvwOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwOrganization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwOrganization.ImageIndex = 0;
            this.tvwOrganization.ImageList = this.ilistEmployee;
            this.tvwOrganization.Location = new System.Drawing.Point(3, 32);
            this.tvwOrganization.Name = "tvwOrganization";
            this.tvwOrganization.SelectedImageIndex = 0;
            this.tvwOrganization.Size = new System.Drawing.Size(334, 437);
            this.tvwOrganization.TabIndex = 2;
            // 
            // ilistEmployee
            // 
            this.ilistEmployee.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilistEmployee.ImageStream")));
            this.ilistEmployee.TransparentColor = System.Drawing.Color.Transparent;
            this.ilistEmployee.Images.SetKeyName(0, "treenode.png");
            // 
            // tpChat
            // 
            this.tpChat.Controls.Add(this.pnlChat);
            this.tpChat.HorizontalScrollbarBarColor = false;
            this.tpChat.HorizontalScrollbarHighlightOnWheel = false;
            this.tpChat.HorizontalScrollbarSize = 2;
            this.tpChat.Location = new System.Drawing.Point(4, 38);
            this.tpChat.Name = "tpChat";
            this.tpChat.Size = new System.Drawing.Size(340, 469);
            this.tpChat.TabIndex = 3;
            this.tpChat.Text = "채팅";
            this.tpChat.VerticalScrollbarBarColor = false;
            this.tpChat.VerticalScrollbarHighlightOnWheel = false;
            this.tpChat.VerticalScrollbarSize = 10;
            // 
            // pnlChat
            // 
            this.pnlChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChat.AutoScroll = true;
            this.pnlChat.BackColor = System.Drawing.Color.White;
            this.pnlChat.Location = new System.Drawing.Point(1, 1);
            this.pnlChat.Margin = new System.Windows.Forms.Padding(1);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(338, 467);
            this.pnlChat.TabIndex = 3;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // lnkSchAdd
            // 
            this.lnkSchAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSchAdd.AutoSize = true;
            this.lnkSchAdd.Location = new System.Drawing.Point(278, 90);
            this.lnkSchAdd.Name = "lnkSchAdd";
            this.lnkSchAdd.Size = new System.Drawing.Size(69, 25);
            this.lnkSchAdd.TabIndex = 2;
            this.lnkSchAdd.Text = "일정 추가";
            this.lnkSchAdd.UseSelectable = true;
            this.lnkSchAdd.Visible = false;
            this.lnkSchAdd.Click += new System.EventHandler(this.lnkSchAdd_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName.Location = new System.Drawing.Point(60, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTeamRank
            // 
            this.lblTeamRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeamRank.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTeamRank.Location = new System.Drawing.Point(60, 62);
            this.lblTeamRank.Name = "lblTeamRank";
            this.lblTeamRank.Size = new System.Drawing.Size(160, 15);
            this.lblTeamRank.TabIndex = 3;
            this.lblTeamRank.Text = "팀 직위";
            this.lblTeamRank.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picSetting
            // 
            this.picSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSetting.BackColor = System.Drawing.Color.White;
            this.picSetting.Image = global::Client.Properties.Resources.settings;
            this.picSetting.Location = new System.Drawing.Point(276, 41);
            this.picSetting.Name = "picSetting";
            this.picSetting.Padding = new System.Windows.Forms.Padding(10);
            this.picSetting.Size = new System.Drawing.Size(36, 36);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSetting.TabIndex = 8;
            this.picSetting.TabStop = false;
            this.picSetting.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.picSetting.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // picLogout
            // 
            this.picLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogout.BackColor = System.Drawing.Color.White;
            this.picLogout.Image = global::Client.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(318, 41);
            this.picLogout.Name = "picLogout";
            this.picLogout.Padding = new System.Windows.Forms.Padding(10);
            this.picLogout.Size = new System.Drawing.Size(36, 36);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogout.TabIndex = 7;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            this.picLogout.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.picLogout.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // picProfile
            // 
            this.picProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProfile.Image = global::Client.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(226, 33);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(44, 44);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 2;
            this.picProfile.TabStop = false;
            this.picProfile.Click += new System.EventHandler(this.picProfile_Click);
            this.picProfile.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.picProfile.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSchedule.AutoScroll = true;
            this.pnlSchedule.BackColor = System.Drawing.Color.White;
            this.pnlSchedule.Location = new System.Drawing.Point(1, 1);
            this.pnlSchedule.Margin = new System.Windows.Forms.Padding(1);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(338, 467);
            this.pnlSchedule.TabIndex = 3;
            // 
            // tpSchedule
            // 
            this.tpSchedule.AutoScroll = true;
            this.tpSchedule.Controls.Add(this.pnlSchedule);
            this.tpSchedule.HorizontalScrollbar = true;
            this.tpSchedule.HorizontalScrollbarBarColor = true;
            this.tpSchedule.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSchedule.HorizontalScrollbarSize = 2;
            this.tpSchedule.Location = new System.Drawing.Point(4, 38);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Size = new System.Drawing.Size(340, 469);
            this.tpSchedule.TabIndex = 2;
            this.tpSchedule.Text = "일정";
            this.tpSchedule.VerticalScrollbar = true;
            this.tpSchedule.VerticalScrollbarBarColor = true;
            this.tpSchedule.VerticalScrollbarHighlightOnWheel = false;
            this.tpSchedule.VerticalScrollbarSize = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.lnkSchAdd);
            this.Controls.Add(this.picSetting);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.lblTeamRank);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.tabMenu);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(360, 600);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tabMenu.ResumeLayout(false);
            this.tpOrganization.ResumeLayout(false);
            this.tpChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.tpSchedule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tabMenu;
        private MetroFramework.Controls.MetroTabPage tpOrganization;
        private System.Windows.Forms.TreeView tvwOrganization;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabPage tpChat;
        private MetroFramework.Controls.MetroLink lnkSchAdd;
        private System.Windows.Forms.PictureBox picProfile;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblTeamRank;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picSetting;
        private MetroFramework.Controls.MetroTextBox txtOrgSearch;
        private System.Windows.Forms.ImageList ilistEmployee;
        private System.Windows.Forms.FlowLayoutPanel pnlChat;
        private MetroFramework.Controls.MetroTabPage tpSchedule;
        private System.Windows.Forms.FlowLayoutPanel pnlSchedule;
    }
}

