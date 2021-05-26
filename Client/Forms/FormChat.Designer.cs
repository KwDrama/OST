
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.pnlChat = new System.Windows.Forms.FlowLayoutPanel();
            this.picSend = new System.Windows.Forms.PictureBox();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.picPlus = new System.Windows.Forms.PictureBox();
            this.txtChat = new MetroFramework.Controls.MetroTextBox();
            this.cms = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.Location = new System.Drawing.Point(6, 72);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(348, 465);
            this.pnlChat.TabIndex = 0;
            // 
            // picSend
            // 
            this.picSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSend.BackColor = System.Drawing.Color.Transparent;
            this.picSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSend.Image = global::Client.Properties.Resources.send;
            this.picSend.Location = new System.Drawing.Point(318, 543);
            this.picSend.Name = "picSend";
            this.picSend.Padding = new System.Windows.Forms.Padding(10);
            this.picSend.Size = new System.Drawing.Size(36, 36);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSend.TabIndex = 10;
            this.picSend.TabStop = false;
            this.picSend.Click += new System.EventHandler(this.picSend_Click);
            // 
            // picSetting
            // 
            this.picSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSetting.BackColor = System.Drawing.Color.White;
            this.picSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSetting.Image = ((System.Drawing.Image)(resources.GetObject("picSetting.Image")));
            this.picSetting.Location = new System.Drawing.Point(318, 30);
            this.picSetting.Name = "picSetting";
            this.picSetting.Padding = new System.Windows.Forms.Padding(10);
            this.picSetting.Size = new System.Drawing.Size(36, 36);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSetting.TabIndex = 8;
            this.picSetting.TabStop = false;
            // 
            // picPlus
            // 
            this.picPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPlus.BackColor = System.Drawing.Color.Transparent;
            this.picPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlus.Image = global::Client.Properties.Resources.plus;
            this.picPlus.Location = new System.Drawing.Point(6, 543);
            this.picPlus.Name = "picPlus";
            this.picPlus.Padding = new System.Windows.Forms.Padding(10);
            this.picPlus.Size = new System.Drawing.Size(36, 36);
            this.picPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlus.TabIndex = 10;
            this.picPlus.TabStop = false;
            // 
            // txtChat
            // 
            // 
            // 
            // 
            this.txtChat.CustomButton.Image = null;
            this.txtChat.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txtChat.CustomButton.Name = "";
            this.txtChat.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.txtChat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChat.CustomButton.TabIndex = 1;
            this.txtChat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChat.CustomButton.UseSelectable = true;
            this.txtChat.CustomButton.Visible = false;
            this.txtChat.Lines = new string[0];
            this.txtChat.Location = new System.Drawing.Point(48, 543);
            this.txtChat.MaxLength = 32767;
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.PasswordChar = '\0';
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChat.SelectedText = "";
            this.txtChat.SelectionLength = 0;
            this.txtChat.SelectionStart = 0;
            this.txtChat.ShortcutsEnabled = true;
            this.txtChat.Size = new System.Drawing.Size(264, 51);
            this.txtChat.TabIndex = 11;
            this.txtChat.UseSelectable = true;
            this.txtChat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChat_KeyDown);
            // 
            // cms
            // 
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // txtChat
            // 
            // 
            // 
            // 
            this.txtChat.CustomButton.Image = null;
            this.txtChat.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txtChat.CustomButton.Name = "";
            this.txtChat.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.txtChat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChat.CustomButton.TabIndex = 1;
            this.txtChat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChat.CustomButton.UseSelectable = true;
            this.txtChat.CustomButton.Visible = false;
            this.txtChat.Lines = new string[0];
            this.txtChat.Location = new System.Drawing.Point(48, 543);
            this.txtChat.MaxLength = 32767;
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.PasswordChar = '\0';
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChat.SelectedText = "";
            this.txtChat.SelectionLength = 0;
            this.txtChat.SelectionStart = 0;
            this.txtChat.ShortcutsEnabled = true;
            this.txtChat.Size = new System.Drawing.Size(264, 51);
            this.txtChat.TabIndex = 11;
            this.txtChat.UseSelectable = true;
            this.txtChat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChat_KeyDown);
            // 
            // cms
            // 
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.picSetting);
            this.Controls.Add(this.picPlus);
            this.Controls.Add(this.picSend);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(360, 600);
            this.Name = "FormChat";
            this.Padding = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "섬유2팀";
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.FlowLayoutPanel pnlChat;
        private System.Windows.Forms.PictureBox picSend;
        private System.Windows.Forms.PictureBox picPlus;
        private MetroFramework.Controls.MetroTextBox txtChat;
        private MetroFramework.Controls.MetroContextMenu cms;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}