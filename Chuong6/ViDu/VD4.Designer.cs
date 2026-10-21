namespace LapTrinhWindowsForm.Chuong6.ViDu
{
    partial class VD4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listLinkWebsite = new System.Windows.Forms.ListView();
            this.myWebsite = new System.Windows.Forms.WebBrowser();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm đường dẫn:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(150, 17);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(410, 20);
            this.txtLink.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(150, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(250, 50);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(20, 95);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listLinkWebsite);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.myWebsite);
            this.splitContainer1.Size = new System.Drawing.Size(540, 330);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 5;
            // 
            // listLinkWebsite
            // 
            this.listLinkWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLinkWebsite.HideSelection = false;
            this.listLinkWebsite.Location = new System.Drawing.Point(0, 0);
            this.listLinkWebsite.Name = "listLinkWebsite";
            this.listLinkWebsite.Size = new System.Drawing.Size(178, 328);
            this.listLinkWebsite.TabIndex = 0;
            this.listLinkWebsite.UseCompatibleStateImageBehavior = false;
            this.listLinkWebsite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listLinkWebsite_MouseClick);
            // 
            // myWebsite
            // 
            this.myWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myWebsite.Location = new System.Drawing.Point(0, 0);
            this.myWebsite.Name = "myWebsite";
            this.myWebsite.Size = new System.Drawing.Size(354, 328);
            this.myWebsite.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(460, 440);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // VD4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnThoat);
            this.Name = "VD4";
            this.Text = "SplitContainer";
            this.Load += new System.EventHandler(this.VD4_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listLinkWebsite;
        private System.Windows.Forms.WebBrowser myWebsite;
        private System.Windows.Forms.Button btnThoat;
    }
}