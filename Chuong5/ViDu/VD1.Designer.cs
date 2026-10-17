namespace LapTrinhWindowsForm.Chuong5.ViDu
{
    partial class VD1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VD1));
            this.label1 = new System.Windows.Forms.Label();
            this.cboChonHinh = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.MyImgList = new System.Windows.Forms.ImageList(this.components);
            this.picHinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn hình:";
            // 
            // cboChonHinh
            // 
            this.cboChonHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonHinh.Location = new System.Drawing.Point(110, 37);
            this.cboChonHinh.Name = "cboChonHinh";
            this.cboChonHinh.Size = new System.Drawing.Size(150, 21);
            this.cboChonHinh.TabIndex = 1;
            this.cboChonHinh.SelectedIndexChanged += new System.EventHandler(this.cboChonHinh_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(110, 90);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // MyImgList
            // 
            this.MyImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyImgList.ImageStream")));
            this.MyImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.MyImgList.Images.SetKeyName(0, "anh-phong-canh-66-1.jpg");
            this.MyImgList.Images.SetKeyName(1, "cd8e3f1ed6b630f333889b678b7fe630.jpg");
            this.MyImgList.Images.SetKeyName(2, "hinh-nen-phong-canh-1.png");
            this.MyImgList.Images.SetKeyName(3, "hinh-nen-phong-canh-3.png");
            this.MyImgList.Images.SetKeyName(4, "images.jpg");
            // 
            // picHinh
            // 
            this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHinh.Location = new System.Drawing.Point(300, 25);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(229, 181);
            this.picHinh.TabIndex = 3;
            this.picHinh.TabStop = false;
            // 
            // VD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboChonHinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.picHinh);
            this.Name = "VD1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VD1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChonHinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.ImageList MyImgList;
    }
}