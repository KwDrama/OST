
namespace Client.Forms
{
    partial class FormSchedule
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
            this.gbxToday = new System.Windows.Forms.GroupBox();
            this.gbxAddsche = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbxRange = new System.Windows.Forms.ComboBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblSche_name = new System.Windows.Forms.Label();
            this.lblContext = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAddsche.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxToday
            // 
            this.gbxToday.Location = new System.Drawing.Point(12, 12);
            this.gbxToday.Name = "gbxToday";
            this.gbxToday.Size = new System.Drawing.Size(408, 188);
            this.gbxToday.TabIndex = 0;
            this.gbxToday.TabStop = false;
            this.gbxToday.Text = "오늘의 스케줄";
            // 
            // gbxAddsche
            // 
            this.gbxAddsche.Controls.Add(this.btnAdd);
            this.gbxAddsche.Controls.Add(this.textBox2);
            this.gbxAddsche.Controls.Add(this.textBox1);
            this.gbxAddsche.Controls.Add(this.lblDate);
            this.gbxAddsche.Controls.Add(this.lblContext);
            this.gbxAddsche.Controls.Add(this.lblSche_name);
            this.gbxAddsche.Controls.Add(this.txtNum);
            this.gbxAddsche.Controls.Add(this.lblNum);
            this.gbxAddsche.Controls.Add(this.lblRange);
            this.gbxAddsche.Controls.Add(this.cbxRange);
            this.gbxAddsche.Controls.Add(this.monthCalendar1);
            this.gbxAddsche.Location = new System.Drawing.Point(12, 206);
            this.gbxAddsche.Name = "gbxAddsche";
            this.gbxAddsche.Size = new System.Drawing.Size(408, 325);
            this.gbxAddsche.TabIndex = 0;
            this.gbxAddsche.TabStop = false;
            this.gbxAddsche.Text = "일정 추가";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 106);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // cbxRange
            // 
            this.cbxRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRange.FormattingEnabled = true;
            this.cbxRange.Items.AddRange(new object[] {
            "회사",
            "부서",
            "팀",
            "개인"});
            this.cbxRange.Location = new System.Drawing.Point(100, 24);
            this.cbxRange.Name = "cbxRange";
            this.cbxRange.Size = new System.Drawing.Size(91, 23);
            this.cbxRange.TabIndex = 0;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(12, 27);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(82, 15);
            this.lblRange.TabIndex = 1;
            this.lblRange.Text = "적용 범위 :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(197, 27);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(82, 15);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "사원 번호 :";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(285, 22);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(117, 25);
            this.txtNum.TabIndex = 3;
            // 
            // lblSche_name
            // 
            this.lblSche_name.AutoSize = true;
            this.lblSche_name.Location = new System.Drawing.Point(12, 61);
            this.lblSche_name.Name = "lblSche_name";
            this.lblSche_name.Size = new System.Drawing.Size(47, 15);
            this.lblSche_name.TabIndex = 4;
            this.lblSche_name.Text = "제목 :";
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Location = new System.Drawing.Point(197, 61);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(42, 15);
            this.lblContext.TabIndex = 5;
            this.lblContext.Text = "내용:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "기간 :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 25);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 25);
            this.textBox2.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 31);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "일정 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 543);
            this.Controls.Add(this.gbxAddsche);
            this.Controls.Add(this.gbxToday);
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            this.gbxAddsche.ResumeLayout(false);
            this.gbxAddsche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxToday;
        private System.Windows.Forms.GroupBox gbxAddsche;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.Label lblSche_name;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.ComboBox cbxRange;
    }
}