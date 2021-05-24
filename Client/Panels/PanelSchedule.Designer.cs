
namespace Client.Panels
{
    partial class PanelSchedule
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
        #pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSchedule));
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.dtpStart = new MetroFramework.Controls.MetroDateTime();
            this.dtpEnd = new MetroFramework.Controls.MetroDateTime();
            this.lblStart = new MetroFramework.Controls.MetroLabel();
            this.lblEnd = new MetroFramework.Controls.MetroLabel();
            this.lblRange = new MetroFramework.Controls.MetroLabel();
            this.tleSubmit = new MetroFramework.Controls.MetroTile();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.txtContent = new MetroFramework.Controls.MetroTextBox();
            this.cmbRange = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(60, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PromptText = "일정 제목";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(240, 25);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMark = "일정 제목";
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(60, 86);
            this.dtpStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(240, 29);
            this.dtpStart.TabIndex = 9;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(60, 146);
            this.dtpEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(240, 29);
            this.dtpEnd.TabIndex = 10;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblStart.Location = new System.Drawing.Point(60, 68);
            this.lblStart.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(31, 15);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "시작";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblEnd.Location = new System.Drawing.Point(60, 128);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(31, 15);
            this.lblEnd.TabIndex = 12;
            this.lblEnd.Text = "종료";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblRange.Location = new System.Drawing.Point(60, 188);
            this.lblRange.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(58, 15);
            this.lblRange.TabIndex = 14;
            this.lblRange.Text = "적용 범위";
            // 
            // tleSubmit
            // 
            this.tleSubmit.ActiveControl = null;
            this.tleSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tleSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tleSubmit.Enabled = false;
            this.tleSubmit.Location = new System.Drawing.Point(0, 522);
            this.tleSubmit.Name = "tleSubmit";
            this.tleSubmit.Size = new System.Drawing.Size(360, 48);
            this.tleSubmit.TabIndex = 18;
            this.tleSubmit.Text = "일정 추가";
            this.tleSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tleSubmit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tleSubmit.UseSelectable = true;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.White;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(321, 3);
            this.picClose.Name = "picClose";
            this.picClose.Padding = new System.Windows.Forms.Padding(10);
            this.picClose.Size = new System.Drawing.Size(36, 36);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // txtContent
            // 
            // 
            // 
            // 
            this.txtContent.CustomButton.Image = null;
            this.txtContent.CustomButton.Location = new System.Drawing.Point(42, 2);
            this.txtContent.CustomButton.Name = "";
            this.txtContent.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.txtContent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContent.CustomButton.TabIndex = 1;
            this.txtContent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContent.CustomButton.UseSelectable = true;
            this.txtContent.CustomButton.Visible = false;
            this.txtContent.Lines = new string[0];
            this.txtContent.Location = new System.Drawing.Point(60, 268);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.txtContent.MaxLength = 32767;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PromptText = "내용";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.SelectedText = "";
            this.txtContent.SelectionLength = 0;
            this.txtContent.SelectionStart = 0;
            this.txtContent.ShortcutsEnabled = true;
            this.txtContent.Size = new System.Drawing.Size(240, 200);
            this.txtContent.TabIndex = 19;
            this.txtContent.UseSelectable = true;
            this.txtContent.WaterMark = "내용";
            this.txtContent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContent.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmbRange
            // 
            this.cmbRange.FormattingEnabled = true;
            this.cmbRange.ItemHeight = 23;
            this.cmbRange.Location = new System.Drawing.Point(60, 206);
            this.cmbRange.Name = "cmbRange";
            this.cmbRange.Size = new System.Drawing.Size(240, 29);
            this.cmbRange.TabIndex = 21;
            this.cmbRange.UseSelectable = true;
            // 
            // PanelSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbRange);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.tleSubmit);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.picClose);
            this.Location = new System.Drawing.Point(0, 30);
            this.Name = "PanelSchedule";
            this.Size = new System.Drawing.Size(360, 570);
            this.Load += new System.EventHandler(this.PanelSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroDateTime dtpStart;
        private MetroFramework.Controls.MetroDateTime dtpEnd;
        private MetroFramework.Controls.MetroLabel lblStart;
        private MetroFramework.Controls.MetroLabel lblEnd;
        private MetroFramework.Controls.MetroLabel lblRange;
        private MetroFramework.Controls.MetroTile tleSubmit;
        private MetroFramework.Controls.MetroTextBox txtContent;
        private MetroFramework.Controls.MetroComboBox cmbRange;
    }
}
