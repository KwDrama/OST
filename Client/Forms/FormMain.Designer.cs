
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
            this.tcMenu = new MetroFramework.Controls.MetroTabControl();
            this.tpTreeview = new MetroFramework.Controls.MetroTabPage();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tvw = new System.Windows.Forms.TreeView();
            this.contextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.mnInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChat = new System.Windows.Forms.ToolStripMenuItem();
            this.tpSchedule = new MetroFramework.Controls.MetroTabPage();
            this.btnAddSche = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.tcMenu.SuspendLayout();
            this.tpTreeview.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpTreeview);
            this.tcMenu.Controls.Add(this.tpSchedule);
            this.tcMenu.Location = new System.Drawing.Point(6, 204);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(348, 390);
            this.tcMenu.TabIndex = 1;
            this.tcMenu.UseSelectable = true;
            // 
            // tpTreeview
            // 
            this.tpTreeview.Controls.Add(this.txtSearch);
            this.tpTreeview.Controls.Add(this.tvw);
            this.tpTreeview.HorizontalScrollbarBarColor = true;
            this.tpTreeview.HorizontalScrollbarHighlightOnWheel = false;
            this.tpTreeview.HorizontalScrollbarSize = 6;
            this.tpTreeview.Location = new System.Drawing.Point(4, 38);
            this.tpTreeview.Name = "tpTreeview";
            this.tpTreeview.Size = new System.Drawing.Size(340, 348);
            this.tpTreeview.TabIndex = 1;
            this.tpTreeview.Text = "사내 조직도";
            this.tpTreeview.VerticalScrollbarBarColor = true;
            this.tpTreeview.VerticalScrollbarHighlightOnWheel = false;
            this.tpTreeview.VerticalScrollbarSize = 11;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(0, 3);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "소속이나 이름 검색";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(337, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "소속이나 이름 검색";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tvw
            // 
            this.tvw.ContextMenuStrip = this.contextMenu;
            this.tvw.Location = new System.Drawing.Point(-4, 32);
            this.tvw.Name = "tvw";
            this.tvw.Size = new System.Drawing.Size(348, 313);
            this.tvw.TabIndex = 2;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnInfo,
            this.mnChat});
            this.contextMenu.Name = "metroContextMenu1";
            this.contextMenu.Size = new System.Drawing.Size(139, 48);
            // 
            // mnInfo
            // 
            this.mnInfo.Name = "mnInfo";
            this.mnInfo.Size = new System.Drawing.Size(138, 22);
            this.mnInfo.Text = "정보";
            this.mnInfo.Click += new System.EventHandler(this.mnInfo_Click);
            // 
            // mnChat
            // 
            this.mnChat.Name = "mnChat";
            this.mnChat.Size = new System.Drawing.Size(138, 22);
            this.mnChat.Text = "채팅방 이동";
            this.mnChat.Click += new System.EventHandler(this.mnChat_Click);
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.btnAddSche);
            this.tpSchedule.HorizontalScrollbarBarColor = true;
            this.tpSchedule.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSchedule.HorizontalScrollbarSize = 6;
            this.tpSchedule.Location = new System.Drawing.Point(4, 38);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Size = new System.Drawing.Size(340, 348);
            this.tpSchedule.TabIndex = 2;
            this.tpSchedule.Text = "일정";
            this.tpSchedule.VerticalScrollbarBarColor = true;
            this.tpSchedule.VerticalScrollbarHighlightOnWheel = false;
            this.tpSchedule.VerticalScrollbarSize = 11;
            // 
            // btnAddSche
            // 
            this.btnAddSche.BackColor = System.Drawing.Color.Aqua;
            this.btnAddSche.Location = new System.Drawing.Point(269, 3);
            this.btnAddSche.Name = "btnAddSche";
            this.btnAddSche.Size = new System.Drawing.Size(75, 23);
            this.btnAddSche.TabIndex = 2;
            this.btnAddSche.Text = "일정 추가";
            this.btnAddSche.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.ost아이콘_최종;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.gbxProfile);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(360, 590);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.gbxProfile.ResumeLayout(false);
            this.gbxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.tcMenu.ResumeLayout(false);
            this.tpTreeview.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.tpSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProfile;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblRank;
        private MetroFramework.Controls.MetroTabControl tcMenu;
        private MetroFramework.Controls.MetroTabPage tpTreeview;
        private MetroFramework.Controls.MetroTabPage tpSchedule;
        private MetroFramework.Controls.MetroButton btnAddSche;
        private System.Windows.Forms.TreeView tvw;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroContextMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem mnInfo;
        private System.Windows.Forms.ToolStripMenuItem mnChat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

