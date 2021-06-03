
namespace Client.Forms
{
    partial class ControlSchedule
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlSchedule));
            this.lblSche_Name = new MetroFramework.Controls.MetroLabel();
            this.lblStart = new MetroFramework.Controls.MetroLabel();
            this.lblEnd = new MetroFramework.Controls.MetroLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picContent = new System.Windows.Forms.PictureBox();
            this.picSchedule = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSche_Name
            // 
            this.lblSche_Name.AutoSize = true;
            this.lblSche_Name.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSche_Name.Location = new System.Drawing.Point(37, 5);
            this.lblSche_Name.Name = "lblSche_Name";
            this.lblSche_Name.Size = new System.Drawing.Size(65, 19);
            this.lblSche_Name.TabIndex = 1;
            this.lblSche_Name.Text = "스케줄명";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(37, 27);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(72, 19);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "시작 날짜:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(37, 52);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(72, 19);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "종료 날짜:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rank0");
            this.imageList1.Images.SetKeyName(1, "rank1");
            this.imageList1.Images.SetKeyName(2, "rank3");
            this.imageList1.Images.SetKeyName(3, "rank4");
            // 
            // picContent
            // 
            this.picContent.Image = global::Client.Properties.Resources.add;
            this.picContent.Location = new System.Drawing.Point(277, 37);
            this.picContent.Name = "picContent";
            this.picContent.Size = new System.Drawing.Size(40, 40);
            this.picContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContent.TabIndex = 4;
            this.picContent.TabStop = false;
            this.picContent.Click += new System.EventHandler(this.picContent_Click);
            // 
            // picSchedule
            // 
            this.picSchedule.Location = new System.Drawing.Point(0, 0);
            this.picSchedule.Name = "picSchedule";
            this.picSchedule.Size = new System.Drawing.Size(31, 80);
            this.picSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSchedule.TabIndex = 0;
            this.picSchedule.TabStop = false;
            // 
            // ControlSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picContent);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblSche_Name);
            this.Controls.Add(this.picSchedule);
            this.Name = "ControlSchedule";
            this.Size = new System.Drawing.Size(320, 80);
            ((System.ComponentModel.ISupportInitialize)(this.picContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSchedule;
        private MetroFramework.Controls.MetroLabel lblSche_Name;
        private MetroFramework.Controls.MetroLabel lblStart;
        private MetroFramework.Controls.MetroLabel lblEnd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picContent;
    }
}
