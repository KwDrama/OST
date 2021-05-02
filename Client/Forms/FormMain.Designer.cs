
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
            this.gbxProfile = new System.Windows.Forms.GroupBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxMenu = new System.Windows.Forms.GroupBox();
            this.gbx_ReceiveMsg = new System.Windows.Forms.GroupBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pic_Calendar = new System.Windows.Forms.PictureBox();
            this.pic_Tree = new System.Windows.Forms.PictureBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.gbxProfile.SuspendLayout();
            this.gbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
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
            this.gbxProfile.Location = new System.Drawing.Point(4, 101);
            this.gbxProfile.Name = "gbxProfile";
            this.gbxProfile.Size = new System.Drawing.Size(393, 142);
            this.gbxProfile.TabIndex = 0;
            this.gbxProfile.TabStop = false;
            this.gbxProfile.Text = "My Profile";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(119, 119);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(32, 20);
            this.lblTeam.TabIndex = 5;
            this.lblTeam.Text = "팀 :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(119, 56);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(77, 20);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "사원번호 :";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(119, 87);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(47, 20);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "부서 :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(119, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름 :";
            // 
            // gbxMenu
            // 
            this.gbxMenu.Controls.Add(this.lblCompanyName);
            this.gbxMenu.Controls.Add(this.pic_Calendar);
            this.gbxMenu.Controls.Add(this.pic_Tree);
            this.gbxMenu.Location = new System.Drawing.Point(4, 11);
            this.gbxMenu.Name = "gbxMenu";
            this.gbxMenu.Size = new System.Drawing.Size(393, 84);
            this.gbxMenu.TabIndex = 0;
            this.gbxMenu.TabStop = false;
            this.gbxMenu.Text = "Menu";
            // 
            // gbx_ReceiveMsg
            // 
            this.gbx_ReceiveMsg.Location = new System.Drawing.Point(4, 249);
            this.gbx_ReceiveMsg.Name = "gbx_ReceiveMsg";
            this.gbx_ReceiveMsg.Size = new System.Drawing.Size(393, 333);
            this.gbx_ReceiveMsg.TabIndex = 1;
            this.gbx_ReceiveMsg.TabStop = false;
            this.gbx_ReceiveMsg.Text = "받은 메세지함";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("휴먼엑스포", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCompanyName.Location = new System.Drawing.Point(62, 36);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(262, 27);
            this.lblCompanyName.TabIndex = 9;
            this.lblCompanyName.Text = "One International";
            // 
            // pic_Calendar
            // 
            this.pic_Calendar.Image = global::Client.Properties.Resources.캘린더_아이콘;
            this.pic_Calendar.Location = new System.Drawing.Point(334, 23);
            this.pic_Calendar.Name = "pic_Calendar";
            this.pic_Calendar.Size = new System.Drawing.Size(50, 50);
            this.pic_Calendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Calendar.TabIndex = 1;
            this.pic_Calendar.TabStop = false;
            this.pic_Calendar.Click += new System.EventHandler(this.pic_Calendar_Click);
            // 
            // pic_Tree
            // 
            this.pic_Tree.Image = global::Client.Properties.Resources.조직도_아이콘;
            this.pic_Tree.Location = new System.Drawing.Point(6, 23);
            this.pic_Tree.Name = "pic_Tree";
            this.pic_Tree.Size = new System.Drawing.Size(50, 50);
            this.pic_Tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Tree.TabIndex = 0;
            this.pic_Tree.TabStop = false;
            this.pic_Tree.Click += new System.EventHandler(this.pic_Tree_Click);
            // 
            // picProfile
            // 
            this.picProfile.Image = global::Client.Properties.Resources.장백기;
            this.picProfile.Location = new System.Drawing.Point(19, 42);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(80, 80);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 2;
            this.picProfile.TabStop = false;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(259, 26);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(47, 20);
            this.lblRank.TabIndex = 6;
            this.lblRank.Text = "직급 :";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 590);
            this.Controls.Add(this.gbx_ReceiveMsg);
            this.Controls.Add(this.gbxMenu);
            this.Controls.Add(this.gbxProfile);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(360, 590);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(20, 38, 20, 25);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Office messengar Supporing Telecommuting";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.gbxProfile.ResumeLayout(false);
            this.gbxProfile.PerformLayout();
            this.gbxMenu.ResumeLayout(false);
            this.gbxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProfile;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxMenu;
        private System.Windows.Forms.PictureBox pic_Calendar;
        private System.Windows.Forms.PictureBox pic_Tree;
        private System.Windows.Forms.GroupBox gbx_ReceiveMsg;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblRank;
    }
}

