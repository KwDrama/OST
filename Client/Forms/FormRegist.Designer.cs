
namespace Client.Forms
{
    partial class FormRegist
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
            this.lblRegist = new MetroFramework.Controls.MetroLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPw = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegist
            // 
            this.lblRegist.AutoSize = true;
            this.lblRegist.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRegist.Location = new System.Drawing.Point(68, 25);
            this.lblRegist.Name = "lblRegist";
            this.lblRegist.Size = new System.Drawing.Size(260, 25);
            this.lblRegist.TabIndex = 1;
            this.lblRegist.Text = "원 인터내셔널 사원 정보 등록";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Client.Properties.Resources.원인터내셔널_로고;
            this.picLogo.Location = new System.Drawing.Point(12, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(50, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.comboBox4);
            this.gbxInfo.Controls.Add(this.comboBox3);
            this.gbxInfo.Controls.Add(this.comboBox2);
            this.gbxInfo.Controls.Add(this.cbxDepartment);
            this.gbxInfo.Controls.Add(this.textBox4);
            this.gbxInfo.Controls.Add(this.textBox3);
            this.gbxInfo.Controls.Add(this.textBox2);
            this.gbxInfo.Controls.Add(this.textBox1);
            this.gbxInfo.Controls.Add(this.lblPw);
            this.gbxInfo.Controls.Add(this.lblEmail);
            this.gbxInfo.Controls.Add(this.lblPhone);
            this.gbxInfo.Controls.Add(this.lblRank);
            this.gbxInfo.Controls.Add(this.lblName);
            this.gbxInfo.Controls.Add(this.lblDepartment);
            this.gbxInfo.Controls.Add(this.lblGender);
            this.gbxInfo.Controls.Add(this.lblTeam);
            this.gbxInfo.Controls.Add(this.lblPic);
            this.gbxInfo.Controls.Add(this.btnCancel);
            this.gbxInfo.Controls.Add(this.btnEnter);
            this.gbxInfo.Location = new System.Drawing.Point(12, 65);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(358, 466);
            this.gbxInfo.TabIndex = 2;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "사원 정보 기입";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox4.Location = new System.Drawing.Point(103, 295);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "대표이사",
            "이사",
            "부장",
            "차장",
            "과장",
            "대리",
            "주임",
            "사원"});
            this.comboBox3.Location = new System.Drawing.Point(103, 265);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(103, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 17;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "자원본부",
            "섬유본부",
            "철강본부",
            "영업본부"});
            this.cbxDepartment.Location = new System.Drawing.Point(103, 201);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(121, 23);
            this.cbxDepartment.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 25);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 353);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 25);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 25);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 25);
            this.textBox1.TabIndex = 12;
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(19, 388);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(77, 15);
            this.lblPw.TabIndex = 11;
            this.lblPw.Text = "비밀번호 :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 356);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 328);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(77, 15);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "전화번호 :";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(20, 268);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(47, 15);
            this.lblRank.TabIndex = 8;
            this.lblRank.Text = "직급 :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "이름 :";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(19, 204);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(47, 15);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "부서 :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(19, 298);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 15);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "성별 :";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(19, 237);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(32, 15);
            this.lblTeam.TabIndex = 3;
            this.lblTeam.Text = "팀 :";
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(19, 30);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(37, 15);
            this.lblPic.TabIndex = 2;
            this.lblPic.Text = "사진";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(196, 430);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 30);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "등록";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // FormRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 543);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.lblRegist);
            this.Controls.Add(this.picLogo);
            this.Name = "FormRegist";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroLabel lblRegist;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}