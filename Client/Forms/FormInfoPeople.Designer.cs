
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
            this.lblPhoneT = new MetroFramework.Controls.MetroLabel();
            this.lblTeamT = new MetroFramework.Controls.MetroLabel();
            this.lblRankT = new MetroFramework.Controls.MetroLabel();
            this.lblNameT = new MetroFramework.Controls.MetroLabel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblTeam = new MetroFramework.Controls.MetroLabel();
            this.lblRank = new MetroFramework.Controls.MetroLabel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhoneT
            // 
            this.lblPhoneT.AutoSize = true;
            this.lblPhoneT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPhoneT.Location = new System.Drawing.Point(192, 180);
            this.lblPhoneT.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblPhoneT.Name = "lblPhoneT";
            this.lblPhoneT.Size = new System.Drawing.Size(51, 19);
            this.lblPhoneT.TabIndex = 21;
            this.lblPhoneT.Text = "연락처";
            // 
            // lblTeamT
            // 
            this.lblTeamT.AutoSize = true;
            this.lblTeamT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTeamT.Location = new System.Drawing.Point(192, 102);
            this.lblTeamT.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblTeamT.Name = "lblTeamT";
            this.lblTeamT.Size = new System.Drawing.Size(37, 19);
            this.lblTeamT.TabIndex = 20;
            this.lblTeamT.Text = "소속";
            // 
            // lblRankT
            // 
            this.lblRankT.AutoSize = true;
            this.lblRankT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRankT.Location = new System.Drawing.Point(192, 141);
            this.lblRankT.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblRankT.Name = "lblRankT";
            this.lblRankT.Size = new System.Drawing.Size(37, 19);
            this.lblRankT.TabIndex = 19;
            this.lblRankT.Text = "직급";
            // 
            // lblNameT
            // 
            this.lblNameT.AutoSize = true;
            this.lblNameT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNameT.Location = new System.Drawing.Point(192, 63);
            this.lblNameT.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblNameT.Name = "lblNameT";
            this.lblNameT.Size = new System.Drawing.Size(37, 19);
            this.lblNameT.TabIndex = 18;
            this.lblNameT.Text = "이름";
            // 
            // picProfile
            // 
            this.picProfile.Image = global::Client.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(23, 63);
            this.picProfile.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(136, 136);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 17;
            this.picProfile.TabStop = false;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(249, 102);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(58, 19);
            this.lblTeam.TabIndex = 22;
            this.lblTeam.Text = "자원3팀";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(249, 141);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(37, 19);
            this.lblRank.TabIndex = 23;
            this.lblRank.Text = "팀장";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(249, 180);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 19);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "070-8888-8888";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(249, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 19);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "홍길동";
            // 
            // FormInfoPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 222);
            this.Controls.Add(this.lblPhoneT);
            this.Controls.Add(this.lblTeamT);
            this.Controls.Add(this.lblRankT);
            this.Controls.Add(this.lblNameT);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.KeyPreview = true;
            this.Name = "FormInfoPeople";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Information";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInfoPeople_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPhoneT;
        private MetroFramework.Controls.MetroLabel lblTeamT;
        private MetroFramework.Controls.MetroLabel lblRankT;
        private MetroFramework.Controls.MetroLabel lblNameT;
        private System.Windows.Forms.PictureBox picProfile;
        private MetroFramework.Controls.MetroLabel lblTeam;
        private MetroFramework.Controls.MetroLabel lblRank;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel lblName;
    }
}