﻿
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.White;
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
            this.lblTitle.Size = new System.Drawing.Size(38, 19);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Title";
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblChat.Location = new System.Drawing.Point(83, 45);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(64, 19);
            this.lblChat.TabIndex = 19;
            this.lblChat.Text = "Last chat";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(214, 16);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 48);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "A.M 12:02";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ControlRoom";
            this.Size = new System.Drawing.Size(330, 80);
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
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
