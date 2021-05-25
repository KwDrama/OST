
namespace Client.Forms
{
    partial class FormInfoPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblRank = new MetroFramework.Controls.MetroLabel();
            this.lblTeam = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNum = new MetroFramework.Controls.MetroLabel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(162, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름: ";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(162, 112);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(40, 19);
            this.lblRank.TabIndex = 2;
            this.lblRank.Text = "직급:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(162, 147);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(44, 19);
            this.lblTeam.TabIndex = 3;
            this.lblTeam.Text = "소속: ";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(162, 178);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(58, 19);
            this.lblPhoneNum.TabIndex = 4;
            this.lblPhoneNum.Text = "연락처: ";
            // 
            // picProfile
            // 
            this.picProfile.Image = global::Client.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(23, 77);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(120, 120);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // FormInfoPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picProfile);
            this.KeyPreview = true;
            this.Name = "FormInfoPeople";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Information";
            this.Shown += new System.EventHandler(this.FormInfoPeople_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInfoPeople_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfile;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblRank;
        private MetroFramework.Controls.MetroLabel lblTeam;
        private MetroFramework.Controls.MetroLabel lblPhoneNum;
    }
}