
namespace Client.Forms
{
    partial class FormInfoDep
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
            this.picDepartment = new System.Windows.Forms.PictureBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblContent = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // picDepartment
            // 
            this.picDepartment.Image = global::Client.Properties.Resources.department;
            this.picDepartment.Location = new System.Drawing.Point(23, 77);
            this.picDepartment.Name = "picDepartment";
            this.picDepartment.Size = new System.Drawing.Size(120, 120);
            this.picDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDepartment.TabIndex = 0;
            this.picDepartment.TabStop = false;
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
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(162, 111);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(44, 19);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "업무: ";
            // 
            // FormInfoDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picDepartment);
            this.KeyPreview = true;
            this.Name = "FormInfoDep";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Information";
            this.Shown += new System.EventHandler(this.FormInfoDep_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInfoDep_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDepartment;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblContent;
    }
}