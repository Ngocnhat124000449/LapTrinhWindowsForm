namespace LapTrinhWindowsForm.Chuong6.ViDu
{
    partial class VD2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VD2));
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.myFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureBox
            // 
            this.myPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPictureBox.Location = new System.Drawing.Point(30, 20);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(320, 230);
            this.myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            // 
            // myFlowLayoutPanel
            // 
            this.myFlowLayoutPanel.AutoScroll = true;
            this.myFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myFlowLayoutPanel.Location = new System.Drawing.Point(30, 270);
            this.myFlowLayoutPanel.Name = "myFlowLayoutPanel";
            this.myFlowLayoutPanel.Size = new System.Drawing.Size(320, 70);
            this.myFlowLayoutPanel.TabIndex = 1;
            this.myFlowLayoutPanel.WrapContents = false;
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "Ảnh chụp màn hình 2025-09-25 081952.png");
            this.myImageList.Images.SetKeyName(1, "Ảnh chụp màn hình 2025-11-10 094514.png");
            this.myImageList.Images.SetKeyName(2, "Ảnh chụp màn hình 2025-11-10 104019.png");
            this.myImageList.Images.SetKeyName(3, "Ảnh chụp màn hình 2025-11-10 104211.png");
            this.myImageList.Images.SetKeyName(4, "Ảnh chụp màn hình 2025-11-10 115400.png");
            this.myImageList.Images.SetKeyName(5, "Ảnh chụp màn hình 2025-11-10 115651.png");
            this.myImageList.Images.SetKeyName(6, "Ảnh chụp màn hình 2025-11-12 040313.png");
            this.myImageList.Images.SetKeyName(7, "Ảnh chụp màn hình 2025-11-12 040331.png");
            this.myImageList.Images.SetKeyName(8, "Ảnh chụp màn hình 2025-11-21 155748.png");
            this.myImageList.Images.SetKeyName(9, "Ảnh chụp màn hình 2025-11-25 143613.png");
            this.myImageList.Images.SetKeyName(10, "Ảnh chụp màn hình 2026-03-21 214913.png");
            this.myImageList.Images.SetKeyName(11, "Screenshot 2026-05-30 120114.png");
            this.myImageList.Images.SetKeyName(12, "Screenshot 2026-06-09 194404.png");
            // 
            // VD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 360);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.myFlowLayoutPanel);
            this.Name = "VD2";
            this.Text = "FlowLayoutPanel";
            this.Load += new System.EventHandler(this.VD2_Load);
            this.Click += new System.EventHandler(this.VD2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.FlowLayoutPanel myFlowLayoutPanel;
        private System.Windows.Forms.ImageList myImageList;
    }
}