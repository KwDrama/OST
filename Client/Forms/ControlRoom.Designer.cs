
namespace Client.Forms
{
    partial class ControlRoom
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
        private void InitializeComponent()
        {
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.lblChat = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.lblTeamRank = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Transparent;
            this.picProfile.Image = global::Client.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(16, 16);
            this.picProfile.Margin = new System.Windows.Forms.Padding(16);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(48, 48);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 18;
            this.picProfile.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitle.Location = new System.Drawing.Point(83, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 19);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "홍길동";
            this.lblTitle.UseCustomBackColor = true;
            // 
            // lblChat
            // 
            this.lblChat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblChat.Location = new System.Drawing.Point(83, 45);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(145, 19);
            this.lblChat.TabIndex = 19;
            this.lblChat.Text = "Last chat";
            this.lblChat.UseCustomBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTime.Location = new System.Drawing.Point(234, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 19);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "오전 12:38";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.UseCustomBackColor = true;
            this.lblTime.UseCustomForeColor = true;
            // 
            // lblTeamRank
            // 
            this.lblTeamRank.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTeamRank.ForeColor = System.Drawing.Color.DimGray;
            this.lblTeamRank.Location = new System.Drawing.Point(184, 16);
            this.lblTeamRank.Name = "lblTeamRank";
            this.lblTeamRank.Size = new System.Drawing.Size(120, 19);
            this.lblTeamRank.TabIndex = 19;
            this.lblTeamRank.Text = "자원본부 본부장";
            this.lblTeamRank.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTeamRank.UseCustomBackColor = true;
            this.lblTeamRank.UseCustomForeColor = true;
            // 
            // ControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblTeamRank);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ControlRoom";
            this.Size = new System.Drawing.Size(320, 80);
            this.UseCustomBackColor = true;
            this.MouseEnter += new System.EventHandler(this.ControlRoom_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ControlRoom_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfile;
        private MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroLabel lblChat;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel lblTeamRank;
    }
}
