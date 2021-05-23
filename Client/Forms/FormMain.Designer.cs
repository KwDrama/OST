
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
            this.gbxProfile = new System.Windows.Forms.GroupBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabMenu = new MetroFramework.Controls.MetroTabControl();
            this.tpOrganization = new MetroFramework.Controls.MetroTabPage();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tvwOrganization = new System.Windows.Forms.TreeView();
            this.cms = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChat = new System.Windows.Forms.ToolStripMenuItem();
            this.tpSchedule = new MetroFramework.Controls.MetroTabPage();
            this.tpChat = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lnkSchAdd = new MetroFramework.Controls.MetroLink();
            this.gbxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.tpOrganization.SuspendLayout();
            this.cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProfile
            // 
            this.gbxProfile.Controls.Add(this.lblRank);
            this.gbxProfile.Controls.Add(this.lblTeam);
            this.gbxProfile.Controls.Add(this.lblNum);
            this.gbxProfile.Controls.Add(this.lblDepartment);
            this.gbxProfile.Controls.Add(this.picProfile);
            this.gbxProfile.Controls.Add(this.lblName);
            this.gbxProfile.Location = new System.Drawing.Point(6, 71);
            this.gbxProfile.Name = "gbxProfile";
            this.gbxProfile.Size = new System.Drawing.Size(348, 127);
            this.gbxProfile.TabIndex = 0;
            this.gbxProfile.TabStop = false;
            this.gbxProfile.Text = "My Profile";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(223, 19);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(38, 15);
            this.lblRank.TabIndex = 6;
            this.lblRank.Text = "직급 :";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(119, 107);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(26, 15);
            this.lblTeam.TabIndex = 5;
            this.lblTeam.Text = "팀 :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(119, 50);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(62, 15);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "사원번호 :";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(119, 79);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(38, 15);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "부서 :";
            // 
            // picProfile
            // 
            this.picProfile.Image = global::Client.Properties.Resources.사람프로필_아이콘;
            this.picProfile.Location = new System.Drawing.Point(18, 26);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(80, 80);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 2;
            this.picProfile.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(119, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름 :";
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tpOrganization);
            this.tabMenu.Controls.Add(this.tpSchedule);
            this.tabMenu.Controls.Add(this.tpChat);
            this.tabMenu.Location = new System.Drawing.Point(6, 204);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(348, 390);
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
            this.tpOrganization.HorizontalScrollbarSize = 3;
            this.tpOrganization.Location = new System.Drawing.Point(4, 38);
            this.tpOrganization.Name = "tpOrganization";
            this.tpOrganization.Size = new System.Drawing.Size(340, 348);
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
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "소속이나 이름 검색";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(334, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "소속이나 이름 검색";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tvwOrganization
            // 
            this.tvwOrganization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwOrganization.Location = new System.Drawing.Point(3, 32);
            this.tvwOrganization.Name = "tvwOrganization";
            this.tvwOrganization.Size = new System.Drawing.Size(334, 313);
            this.tvwOrganization.TabIndex = 2;
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
            // tpSchedule
            // 
            this.tpSchedule.AutoScroll = true;
            this.tpSchedule.HorizontalScrollbar = true;
            this.tpSchedule.HorizontalScrollbarBarColor = true;
            this.tpSchedule.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSchedule.HorizontalScrollbarSize = 3;
            this.tpSchedule.Location = new System.Drawing.Point(4, 38);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Size = new System.Drawing.Size(340, 348);
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
            this.tpChat.HorizontalScrollbarSize = 8;
            this.tpChat.Location = new System.Drawing.Point(4, 38);
            this.tpChat.Name = "tpChat";
            this.tpChat.Size = new System.Drawing.Size(340, 348);
            this.tpChat.TabIndex = 3;
            this.tpChat.Text = "채팅";
            this.tpChat.VerticalScrollbarBarColor = true;
            this.tpChat.VerticalScrollbarHighlightOnWheel = false;
            this.tpChat.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // lnkSchAdd
            // 
            this.lnkSchAdd.AutoSize = true;
            this.lnkSchAdd.Location = new System.Drawing.Point(278, 211);
            this.lnkSchAdd.Name = "lnkSchAdd";
            this.lnkSchAdd.Size = new System.Drawing.Size(69, 25);
            this.lnkSchAdd.TabIndex = 2;
            this.lnkSchAdd.Text = "일정 추가";
            this.lnkSchAdd.UseSelectable = true;
            this.lnkSchAdd.Visible = false;
            this.lnkSchAdd.Click += new System.EventHandler(this.lnkSchAdd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.lnkSchAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.gbxProfile);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(360, 590);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.gbxProfile.ResumeLayout(false);
            this.gbxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tpOrganization.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProfile;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblRank;
        private MetroFramework.Controls.MetroTabControl tabMenu;
        private MetroFramework.Controls.MetroTabPage tpOrganization;
        private MetroFramework.Controls.MetroTabPage tpSchedule;
        private System.Windows.Forms.TreeView tvwOrganization;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroContextMenu cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiChat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabPage tpChat;
        private MetroFramework.Controls.MetroLink lnkSchAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfo;
    }
}

