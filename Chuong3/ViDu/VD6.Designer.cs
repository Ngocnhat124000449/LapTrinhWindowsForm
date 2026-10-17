namespace LapTrinhWindowsForm.Chuong3.ViDu
{
    partial class VD6
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.chkMang = new System.Windows.Forms.CheckBox();
            this.chkXLAnh = new System.Windows.Forms.CheckBox();
            this.chkWeb = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTieuDe.Location = new System.Drawing.Point(130, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(193, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thông tin sinh viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(40, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(69, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Nhập họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(150, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(40, 115);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(28, 13);
            this.lblLop.TabIndex = 3;
            this.lblLop.Text = "Lớp:";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(150, 112);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(220, 20);
            this.txtLop.TabIndex = 4;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(40, 160);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(145, 13);
            this.lblMonHoc.TabIndex = 5;
            this.lblMonHoc.Text = "Danh sách môn học tự chọn:";
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(80, 190);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(84, 17);
            this.chkCSharp.TabIndex = 6;
            this.chkCSharp.Text = "Lập trình C#";
            // 
            // chkMang
            // 
            this.chkMang.AutoSize = true;
            this.chkMang.Location = new System.Drawing.Point(80, 215);
            this.chkMang.Name = "chkMang";
            this.chkMang.Size = new System.Drawing.Size(97, 17);
            this.chkMang.TabIndex = 7;
            this.chkMang.Text = "Mạng máy tính";
            // 
            // chkXLAnh
            // 
            this.chkXLAnh.AutoSize = true;
            this.chkXLAnh.Location = new System.Drawing.Point(80, 240);
            this.chkXLAnh.Name = "chkXLAnh";
            this.chkXLAnh.Size = new System.Drawing.Size(70, 17);
            this.chkXLAnh.TabIndex = 8;
            this.chkXLAnh.Text = "Xử lý ảnh";
            // 
            // chkWeb
            // 
            this.chkWeb.AutoSize = true;
            this.chkWeb.Location = new System.Drawing.Point(80, 265);
            this.chkWeb.Name = "chkWeb";
            this.chkWeb.Size = new System.Drawing.Size(93, 17);
            this.chkWeb.TabIndex = 9;
            this.chkWeb.Text = "Lập trình Web";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(120, 310);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 32);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(260, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // VD6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 370);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.chkCSharp);
            this.Controls.Add(this.chkMang);
            this.Controls.Add(this.chkXLAnh);
            this.Controls.Add(this.chkWeb);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Name = "VD6";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VD6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.CheckBox chkMang;
        private System.Windows.Forms.CheckBox chkXLAnh;
        private System.Windows.Forms.CheckBox chkWeb;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}