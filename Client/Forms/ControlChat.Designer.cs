
namespace Client.Forms
{
    partial class ControlChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlChat));
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.SystemColors.Control;
            this.lblText.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblText.Location = new System.Drawing.Point(48, 25);
            this.lblText.Margin = new System.Windows.Forms.Padding(0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(264, 50);
            this.lblText.TabIndex = 0;
            this.lblText.Text = resources.GetString("lblText.Text");
            this.lblText.WrapToLine = true;
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Transparent;
            this.picProfile.Image = global::Client.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(8, 10);
            this.picProfile.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(32, 32);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 19;
            this.picProfile.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblName.Location = new System.Drawing.Point(48, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "홍길동";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTime.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTime.Location = new System.Drawing.Point(252, 75);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 15);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "오전 12:38";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTime.UseCustomBackColor = true;
            this.lblTime.UseCustomForeColor = true;
            // 
            // ControlChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlChat";
            this.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Size = new System.Drawing.Size(320, 100);
            this.UseCustomBackColor = true;
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblText;
        private System.Windows.Forms.PictureBox picProfile;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblTime;
    }
}
