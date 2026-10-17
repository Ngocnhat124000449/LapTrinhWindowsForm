namespace LapTrinhWindowsForm.Chuong4.ViDu
{
    partial class VD5
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
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblThu = new System.Windows.Forms.Label();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.lblNgayThangNam = new System.Windows.Forms.Label();
            this.txtNgayThangNam = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTP1
            // 
            this.DTP1.Location = new System.Drawing.Point(30, 25);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(350, 20);
            this.DTP1.TabIndex = 0;
            this.DTP1.ValueChanged += new System.EventHandler(this.DTP1_ValueChanged);
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(30, 60);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(350, 20);
            this.txtGiaTri.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(30, 110);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(32, 13);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Ngày";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(180, 107);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(200, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(30, 145);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(38, 13);
            this.lblThang.TabIndex = 4;
            this.lblThang.Text = "Tháng";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(180, 142);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(200, 20);
            this.txtThang.TabIndex = 5;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(30, 180);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(29, 13);
            this.lblNam.TabIndex = 6;
            this.lblNam.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(180, 177);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(200, 20);
            this.txtNam.TabIndex = 7;
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Location = new System.Drawing.Point(30, 215);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(26, 13);
            this.lblThu.TabIndex = 8;
            this.lblThu.Text = "Thứ";
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(180, 212);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(200, 20);
            this.txtThu.TabIndex = 9;
            // 
            // lblNgayThangNam
            // 
            this.lblNgayThangNam.AutoSize = true;
            this.lblNgayThangNam.Location = new System.Drawing.Point(30, 250);
            this.lblNgayThangNam.Name = "lblNgayThangNam";
            this.lblNgayThangNam.Size = new System.Drawing.Size(91, 13);
            this.lblNgayThangNam.TabIndex = 10;
            this.lblNgayThangNam.Text = "Ngày-Tháng-Năm";
            // 
            // txtNgayThangNam
            // 
            this.txtNgayThangNam.Location = new System.Drawing.Point(180, 247);
            this.txtNgayThangNam.Name = "txtNgayThangNam";
            this.txtNgayThangNam.Size = new System.Drawing.Size(200, 20);
            this.txtNgayThangNam.TabIndex = 11;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(300, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 32);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // VD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.lblThu);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.lblNgayThangNam);
            this.Controls.Add(this.txtNgayThangNam);
            this.Controls.Add(this.btnThoat);
            this.Name = "VD5";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.VD5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.Label lblNgayThangNam;
        private System.Windows.Forms.TextBox txtNgayThangNam;
        private System.Windows.Forms.Button btnThoat;
    }
}