
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
            this.txtChatContext = new MetroFramework.Controls.MetroTextBox();
            this.gbxChatName1 = new System.Windows.Forms.GroupBox();
            this.lblChatName = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.txtInput = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.gbxChatName1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChatContext
            // 
            // 
            // 
            // 
            this.txtChatContext.CustomButton.Image = null;
            this.txtChatContext.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtChatContext.CustomButton.Name = "";
            this.txtChatContext.CustomButton.Size = new System.Drawing.Size(391, 391);
            this.txtChatContext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChatContext.CustomButton.TabIndex = 1;
            this.txtChatContext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChatContext.CustomButton.UseSelectable = true;
            this.txtChatContext.CustomButton.Visible = false;
            this.txtChatContext.Lines = new string[0];
            this.txtChatContext.Location = new System.Drawing.Point(24, 128);
            this.txtChatContext.MaxLength = 32767;
            this.txtChatContext.Multiline = true;
            this.txtChatContext.Name = "txtChatContext";
            this.txtChatContext.PasswordChar = '\0';
            this.txtChatContext.ReadOnly = true;
            this.txtChatContext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatContext.SelectedText = "";
            this.txtChatContext.SelectionLength = 0;
            this.txtChatContext.SelectionStart = 0;
            this.txtChatContext.ShortcutsEnabled = true;
            this.txtChatContext.Size = new System.Drawing.Size(403, 393);
            this.txtChatContext.TabIndex = 1;
            this.txtChatContext.UseSelectable = true;
            this.txtChatContext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChatContext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gbxChatName1
            // 
            this.gbxChatName1.Controls.Add(this.lblChatName);
            this.gbxChatName1.Controls.Add(this.picInfo);
            this.gbxChatName1.Controls.Add(this.picClose);
            this.gbxChatName1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxChatName1.Location = new System.Drawing.Point(20, 60);
            this.gbxChatName1.Name = "gbxChatName1";
            this.gbxChatName1.Size = new System.Drawing.Size(410, 62);
            this.gbxChatName1.TabIndex = 5;
            this.gbxChatName1.TabStop = false;
            this.gbxChatName1.Text = "그룹채팅";
            // 
            // lblChatName
            // 
            this.lblChatName.AutoSize = true;
            this.lblChatName.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChatName.Location = new System.Drawing.Point(6, 28);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(153, 24);
            this.lblChatName.TabIndex = 9;
            this.lblChatName.Text = "부서명 / 팀명";
            // 
            // picInfo
            // 
            this.picInfo.Image = global::Client.Properties.Resources.Info_아이콘;
            this.picInfo.Location = new System.Drawing.Point(316, 12);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(40, 40);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInfo.TabIndex = 3;
            this.picInfo.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Image = global::Client.Properties.Resources.닫기_아이콘;
            this.picClose.Location = new System.Drawing.Point(364, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(40, 40);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 4;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // txtInput
            // 
            // 
            // 
            // 
            this.txtInput.CustomButton.Image = null;
            this.txtInput.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.txtInput.CustomButton.Name = "";
            this.txtInput.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInput.CustomButton.TabIndex = 1;
            this.txtInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInput.CustomButton.UseSelectable = true;
            this.txtInput.CustomButton.Visible = false;
            this.txtInput.Lines = new string[0];
            this.txtInput.Location = new System.Drawing.Point(66, 527);
            this.txtInput.MaxLength = 32767;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInput.SelectedText = "";
            this.txtInput.SelectionLength = 0;
            this.txtInput.SelectionStart = 0;
            this.txtInput.ShortcutsEnabled = true;
            this.txtInput.Size = new System.Drawing.Size(310, 40);
            this.txtInput.TabIndex = 6;
            this.txtInput.UseSelectable = true;
            this.txtInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.더보기_아이콘;
            this.pictureBox1.Location = new System.Drawing.Point(20, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(382, 527);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(44, 40);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseSelectable = true;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 590);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.gbxChatName1);
            this.Controls.Add(this.txtChatContext);
            this.IsMdiContainer = true;
            this.Name = "FormChat";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.gbxChatName1.ResumeLayout(false);
            this.gbxChatName1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtChatContext;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.GroupBox gbxChatName1;
        private MetroFramework.Controls.MetroTextBox txtInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSend;
        private System.Windows.Forms.Label lblChatName;
    }
}