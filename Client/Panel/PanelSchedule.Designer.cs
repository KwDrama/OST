
namespace Client.Panel
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSchedule));
            this.txtSche_name = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.lblStartDay = new MetroFramework.Controls.MetroLabel();
            this.lblDeadLine = new MetroFramework.Controls.MetroLabel();
            this.lblRange = new MetroFramework.Controls.MetroLabel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.txtMemo = new MetroFramework.Controls.MetroTextBox();
            this.cbxRange = new MetroFramework.Controls.MetroComboBox();
            this.picSche = new System.Windows.Forms.PictureBox();
            this.btnAddSche = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSche)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSche_name
            // 
            // 
            // 
            // 
            this.txtSche_name.CustomButton.Image = null;
            this.txtSche_name.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtSche_name.CustomButton.Name = "";
            this.txtSche_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSche_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSche_name.CustomButton.TabIndex = 1;
            this.txtSche_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSche_name.CustomButton.UseSelectable = true;
            this.txtSche_name.CustomButton.Visible = false;
            this.txtSche_name.Lines = new string[0];
            this.txtSche_name.Location = new System.Drawing.Point(80, 231);
            this.txtSche_name.MaxLength = 32767;
            this.txtSche_name.Name = "txtSche_name";
            this.txtSche_name.PasswordChar = '\0';
            this.txtSche_name.PromptText = "일정 제목";
            this.txtSche_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSche_name.SelectedText = "";
            this.txtSche_name.SelectionLength = 0;
            this.txtSche_name.SelectionStart = 0;
            this.txtSche_name.ShortcutsEnabled = true;
            this.txtSche_name.Size = new System.Drawing.Size(200, 23);
            this.txtSche_name.TabIndex = 8;
            this.txtSche_name.UseSelectable = true;
            this.txtSche_name.WaterMark = "일정 제목";
            this.txtSche_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSche_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(80, 291);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 9;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(80, 358);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 10;
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Location = new System.Drawing.Point(80, 269);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(51, 19);
            this.lblStartDay.TabIndex = 11;
            this.lblStartDay.Text = "시작일";
            // 
            // lblDeadLine
            // 
            this.lblDeadLine.AutoSize = true;
            this.lblDeadLine.Location = new System.Drawing.Point(80, 336);
            this.lblDeadLine.Name = "lblDeadLine";
            this.lblDeadLine.Size = new System.Drawing.Size(51, 19);
            this.lblDeadLine.TabIndex = 12;
            this.lblDeadLine.Text = "종료일";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(80, 406);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(69, 19);
            this.lblRange.TabIndex = 14;
            this.lblRange.Text = "적용 범위";
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
            // 
            // txtMemo
            // 
            // 
            // 
            // 
            this.txtMemo.CustomButton.Image = null;
            this.txtMemo.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtMemo.CustomButton.Name = "";
            this.txtMemo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMemo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemo.CustomButton.TabIndex = 1;
            this.txtMemo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemo.CustomButton.UseSelectable = true;
            this.txtMemo.CustomButton.Visible = false;
            this.txtMemo.Lines = new string[0];
            this.txtMemo.Location = new System.Drawing.Point(80, 481);
            this.txtMemo.MaxLength = 32767;
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.PasswordChar = '\0';
            this.txtMemo.PromptText = "메모";
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemo.SelectedText = "";
            this.txtMemo.SelectionLength = 0;
            this.txtMemo.SelectionStart = 0;
            this.txtMemo.ShortcutsEnabled = true;
            this.txtMemo.Size = new System.Drawing.Size(200, 25);
            this.txtMemo.TabIndex = 15;
            this.txtMemo.UseSelectable = true;
            this.txtMemo.WaterMark = "메모";
            this.txtMemo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxRange
            // 
            this.cbxRange.FormattingEnabled = true;
            this.cbxRange.ItemHeight = 23;
            this.cbxRange.Items.AddRange(new object[] {
            "회사 전체",
            "본부 전체",
            "부서 전체",
            "팀 전체",
            "개인"});
            this.cbxRange.Location = new System.Drawing.Point(80, 428);
            this.cbxRange.Name = "cbxRange";
            this.cbxRange.Size = new System.Drawing.Size(200, 29);
            this.cbxRange.TabIndex = 16;
            this.cbxRange.UseSelectable = true;
            // 
            // picSche
            // 
            this.picSche.Image = global::Client.Properties.Resources.캘린더_아이콘;
            this.picSche.Location = new System.Drawing.Point(145, 94);
            this.picSche.Name = "picSche";
            this.picSche.Size = new System.Drawing.Size(70, 70);
            this.picSche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSche.TabIndex = 17;
            this.picSche.TabStop = false;
            // 
            // btnAddSche
            // 
            this.btnAddSche.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddSche.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAddSche.Location = new System.Drawing.Point(264, 556);
            this.btnAddSche.Name = "btnAddSche";
            this.btnAddSche.Size = new System.Drawing.Size(83, 30);
            this.btnAddSche.TabIndex = 18;
            this.btnAddSche.Text = "일정 추가";
            this.btnAddSche.UseSelectable = true;
            // 
            // PanelSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddSche);
            this.Controls.Add(this.picSche);
            this.Controls.Add(this.cbxRange);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblDeadLine);
            this.Controls.Add(this.lblStartDay);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.txtSche_name);
            this.Controls.Add(this.picClose);
            this.Name = "PanelSchedule";
            this.Size = new System.Drawing.Size(360, 600);
            this.Load += new System.EventHandler(this.PanelSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private MetroFramework.Controls.MetroTextBox txtSche_name;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel lblStartDay;
        private MetroFramework.Controls.MetroLabel lblDeadLine;
        private MetroFramework.Controls.MetroLabel lblRange;
        private MetroFramework.Controls.MetroTextBox txtMemo;
        private MetroFramework.Controls.MetroComboBox cbxRange;
        private System.Windows.Forms.PictureBox picSche;
        private MetroFramework.Controls.MetroButton btnAddSche;
    }
}
