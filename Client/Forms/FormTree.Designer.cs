
namespace Client.Forms
{
    partial class FormTree
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
            this.tv_viewer = new System.Windows.Forms.TreeView();
            this.gbxTree = new System.Windows.Forms.GroupBox();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.gbxTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_viewer
            // 
            this.tv_viewer.Location = new System.Drawing.Point(3, 72);
            this.tv_viewer.Name = "tv_viewer";
            this.tv_viewer.Size = new System.Drawing.Size(373, 474);
            this.tv_viewer.TabIndex = 0;
            this.tv_viewer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_viewer_NodeMouseDoubleClick);
            // 
            // gbxTree
            // 
            this.gbxTree.Controls.Add(this.pic_Close);
            this.gbxTree.Location = new System.Drawing.Point(3, 13);
            this.gbxTree.Name = "gbxTree";
            this.gbxTree.Size = new System.Drawing.Size(373, 59);
            this.gbxTree.TabIndex = 1;
            this.gbxTree.TabStop = false;
            this.gbxTree.Text = "사내 조직도";
            // 
            // pic_Close
            // 
            this.pic_Close.Image = global::Client.Properties.Resources.닫기_아이콘;
            this.pic_Close.Location = new System.Drawing.Point(332, 18);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(35, 35);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Close.TabIndex = 0;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Click);
            // 
            // FormTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 543);
            this.Controls.Add(this.gbxTree);
            this.Controls.Add(this.tv_viewer);
            this.IsMdiContainer = true;
            this.Name = "FormTree";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FormTree_Load);
            this.gbxTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_viewer;
        private System.Windows.Forms.GroupBox gbxTree;
        private System.Windows.Forms.PictureBox pic_Close;
    }
}