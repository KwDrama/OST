
namespace Client.Forms
{
    partial class FormChat
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
            this.txtContext = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMsg = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContext
            // 
            // 
            // 
            // 
            this.txtContext.CustomButton.Image = null;
            this.txtContext.CustomButton.Location = new System.Drawing.Point(-127, 2);
            this.txtContext.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContext.CustomButton.Name = "";
            this.txtContext.CustomButton.Size = new System.Drawing.Size(483, 483);
            this.txtContext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContext.CustomButton.TabIndex = 1;
            this.txtContext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContext.CustomButton.UseSelectable = true;
            this.txtContext.CustomButton.Visible = false;
            this.txtContext.Lines = new string[0];
            this.txtContext.Location = new System.Drawing.Point(20, 62);
            this.txtContext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContext.MaxLength = 32767;
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.PasswordChar = '\0';
            this.txtContext.ReadOnly = true;
            this.txtContext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContext.SelectedText = "";
            this.txtContext.SelectionLength = 0;
            this.txtContext.SelectionStart = 0;
            this.txtContext.ShortcutsEnabled = true;
            this.txtContext.Size = new System.Drawing.Size(359, 488);
            this.txtContext.TabIndex = 10;
            this.txtContext.UseSelectable = true;
            this.txtContext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.더보기_아이콘;
            this.pictureBox1.Location = new System.Drawing.Point(21, 554);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtMsg
            // 
            // 
            // 
            // 
            this.txtMsg.CustomButton.Image = null;
            this.txtMsg.CustomButton.Location = new System.Drawing.Point(246, 2);
            this.txtMsg.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMsg.CustomButton.Name = "";
            this.txtMsg.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMsg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMsg.CustomButton.TabIndex = 1;
            this.txtMsg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMsg.CustomButton.UseSelectable = true;
            this.txtMsg.CustomButton.Visible = false;
            this.txtMsg.Lines = new string[0];
            this.txtMsg.Location = new System.Drawing.Point(58, 554);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMsg.MaxLength = 32767;
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.PasswordChar = '\0';
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.SelectedText = "";
            this.txtMsg.SelectionLength = 0;
            this.txtMsg.SelectionStart = 0;
            this.txtMsg.ShortcutsEnabled = true;
            this.txtMsg.Size = new System.Drawing.Size(272, 28);
            this.txtMsg.TabIndex = 13;
            this.txtMsg.UseSelectable = true;
            this.txtMsg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMsg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(336, 554);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(43, 28);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseSelectable = true;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContext);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChat";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormChat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtContext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtMsg;
        private MetroFramework.Controls.MetroButton btnSend;
    }
}