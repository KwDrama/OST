
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
            this.tabMenu = new MetroFramework.Controls.MetroTabControl();
            this.tpOrganization = new MetroFramework.Controls.MetroTabPage();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tvwOrganization = new System.Windows.Forms.TreeView();
            this.tpSchedule = new MetroFramework.Controls.MetroTabPage();
            this.tpChat = new MetroFramework.Controls.MetroTabPage();
            this.cms = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChat = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lnkSchAdd = new MetroFramework.Controls.MetroLink();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblTeamRank = new MetroFramework.Controls.MetroLabel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.tabMenu.SuspendLayout();
            this.tpOrganization.SuspendLayout();
            this.cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
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
            this.tabMenu.Location = new System.Drawing.Point(6, 72);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(348, 522);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.UseSelectable = true;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // tpOrganization
            // 
            this.tpOrganization.Controls.Add(this.txtSearch);
            this.tpOrganization.Controls.Add(this.tvwOrganization);
            this.tpOrganization.HorizontalScrollbarBarColor = true;
            this.tpOrganization.HorizontalScrollbarHighlightOnWheel = false;
            this.tpOrganization.HorizontalScrollbarSize = 2;
            this.tpOrganization.Location = new System.Drawing.Point(4, 38);
            this.tpOrganization.Name = "tpOrganization";
            this.tpOrganization.Size = new System.Drawing.Size(340, 480);
            this.tpOrganization.TabIndex = 1;
            this.tpOrganization.Text = "조직도";
            this.tpOrganization.VerticalScrollbarBarColor = true;
            this.tpOrganization.VerticalScrollbarHighlightOnWheel = false;
            this.tpOrganization.VerticalScrollbarSize = 11;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Icon = global::Client.Properties.Resources.search;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "소속이나 이름 검색";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(340, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "소속이나 이름 검색";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tvwOrganization
            // 
            this.tvwOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwOrganization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwOrganization.Location = new System.Drawing.Point(3, 32);
            this.tvwOrganization.Name = "tvwOrganization";
            this.tvwOrganization.Size = new System.Drawing.Size(334, 448);
            this.tvwOrganization.TabIndex = 2;
            // 
            // tpSchedule
            // 
            this.tpSchedule.AutoScroll = true;
            this.tpSchedule.HorizontalScrollbar = true;
            this.tpSchedule.HorizontalScrollbarBarColor = true;
            this.tpSchedule.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSchedule.HorizontalScrollbarSize = 2;
            this.tpSchedule.Location = new System.Drawing.Point(4, 38);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Size = new System.Drawing.Size(340, 480);
            this.tpSchedule.TabIndex = 2;
            this.tpSchedule.Text = "일정";
            this.tpSchedule.VerticalScrollbar = true;
            this.tpSchedule.VerticalScrollbarBarColor = true;
            this.tpSchedule.VerticalScrollbarHighlightOnWheel = false;
            this.tpSchedule.VerticalScrollbarSize = 11;
            // 
            // tpChat
            // 
            this.tpChat.HorizontalScrollbarBarColor = true;
            this.tpChat.HorizontalScrollbarHighlightOnWheel = false;
            this.tpChat.HorizontalScrollbarSize = 4;
            this.tpChat.Location = new System.Drawing.Point(4, 38);
            this.tpChat.Name = "tpChat";
            this.tpChat.Size = new System.Drawing.Size(340, 480);
            this.tpChat.TabIndex = 3;
            this.tpChat.Text = "채팅";
            this.tpChat.VerticalScrollbarBarColor = true;
            this.tpChat.VerticalScrollbarHighlightOnWheel = false;
            this.tpChat.VerticalScrollbarSize = 10;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInfo,
            this.tsmiChat});
            this.cms.Name = "metroContextMenu1";
            this.cms.Size = new System.Drawing.Size(99, 48);
            // 
            // tsmiInfo
            // 
            this.tsmiInfo.Name = "tsmiInfo";
            this.tsmiInfo.Size = new System.Drawing.Size(98, 22);
            this.tsmiInfo.Text = "정보";
            this.tsmiInfo.Click += new System.EventHandler(this.tsmiInfo_Click);
            // 
            // tsmiChat
            // 
            this.tsmiChat.Name = "tsmiChat";
            this.tsmiChat.Size = new System.Drawing.Size(98, 22);
            this.tsmiChat.Text = "채팅";
            this.tsmiChat.Click += new System.EventHandler(this.tsmiChat_Click);
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
            this.lnkSchAdd.Location = new System.Drawing.Point(278, 79);
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
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName.Location = new System.Drawing.Point(83, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTeamRank
            // 
            this.lblTeamRank.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTeamRank.Location = new System.Drawing.Point(83, 51);
            this.lblTeamRank.Name = "lblTeamRank";
            this.lblTeamRank.Size = new System.Drawing.Size(160, 15);
            this.lblTeamRank.TabIndex = 3;
            this.lblTeamRank.Text = "팀 직위";
            this.lblTeamRank.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picLogout
            // 
            this.picLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogout.BackColor = System.Drawing.Color.White;
            this.picLogout.Image = global::Client.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(318, 30);
            this.picLogout.Name = "picLogout";
            this.picLogout.Padding = new System.Windows.Forms.Padding(10);
            this.picLogout.Size = new System.Drawing.Size(36, 36);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogout.TabIndex = 7;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            this.picLogout.MouseEnter += new System.EventHandler(this.picLogout_MouseEnter);
            this.picLogout.MouseLeave += new System.EventHandler(this.picLogout_MouseLeave);
            // 
            // picProfile
            // 
            this.picProfile.Image = global::Client.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(249, 16);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(50, 50);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 2;
            this.picProfile.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.lblTeamRank);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lnkSchAdd);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.tabMenu);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tabMenu;
        private MetroFramework.Controls.MetroTabPage tpOrganization;
        private MetroFramework.Controls.MetroTabPage tpSchedule;
        private System.Windows.Forms.TreeView tvwOrganization;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroContextMenu cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiChat;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabPage tpChat;
        private MetroFramework.Controls.MetroLink lnkSchAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfo;
        private System.Windows.Forms.PictureBox picProfile;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblTeamRank;
        private System.Windows.Forms.PictureBox picLogout;
    }
}

