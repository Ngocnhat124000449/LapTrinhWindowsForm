namespace LapTrinhWindowsForm.Chuong3.ViDu
{
    partial class VD7
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
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.grpNganhHoc = new System.Windows.Forms.GroupBox();
            this.radCNPM = new System.Windows.Forms.RadioButton();
            this.radKTMT = new System.Windows.Forms.RadioButton();
            this.radMMTTT = new System.Windows.Forms.RadioButton();
            this.radHTTT = new System.Windows.Forms.RadioButton();
            this.grpNoiDung = new System.Windows.Forms.GroupBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpGioiTinh.SuspendLayout();
            this.grpNganhHoc.SuspendLayout();
            this.grpNoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(193, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thông tin sinh viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(42, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(30, 110);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(35, 13);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(110, 107);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(200, 20);
            this.txtKhoa.TabIndex = 4;
            // 
            // grpGioiTinh
            // 
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Location = new System.Drawing.Point(30, 145);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(280, 55);
            this.grpGioiTinh.TabIndex = 5;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(20, 22);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(100, 22);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 1;
            this.radNu.Text = "Nữ";
            // 
            // grpNganhHoc
            // 
            this.grpNganhHoc.Controls.Add(this.radCNPM);
            this.grpNganhHoc.Controls.Add(this.radKTMT);
            this.grpNganhHoc.Controls.Add(this.radMMTTT);
            this.grpNganhHoc.Controls.Add(this.radHTTT);
            this.grpNganhHoc.Location = new System.Drawing.Point(30, 210);
            this.grpNganhHoc.Name = "grpNganhHoc";
            this.grpNganhHoc.Size = new System.Drawing.Size(280, 150);
            this.grpNganhHoc.TabIndex = 6;
            this.grpNganhHoc.TabStop = false;
            this.grpNganhHoc.Text = "Chọn ngành học";
            // 
            // radCNPM
            // 
            this.radCNPM.AutoSize = true;
            this.radCNPM.Checked = true;
            this.radCNPM.Location = new System.Drawing.Point(20, 25);
            this.radCNPM.Name = "radCNPM";
            this.radCNPM.Size = new System.Drawing.Size(129, 17);
            this.radCNPM.TabIndex = 0;
            this.radCNPM.TabStop = true;
            this.radCNPM.Text = "Công nghệ phần mềm";
            // 
            // radKTMT
            // 
            this.radKTMT.AutoSize = true;
            this.radKTMT.Location = new System.Drawing.Point(20, 55);
            this.radKTMT.Name = "radKTMT";
            this.radKTMT.Size = new System.Drawing.Size(108, 17);
            this.radKTMT.TabIndex = 1;
            this.radKTMT.Text = "Kỹ thuật máy tính";
            // 
            // radMMTTT
            // 
            this.radMMTTT.AutoSize = true;
            this.radMMTTT.Location = new System.Drawing.Point(20, 85);
            this.radMMTTT.Name = "radMMTTT";
            this.radMMTTT.Size = new System.Drawing.Size(173, 17);
            this.radMMTTT.TabIndex = 2;
            this.radMMTTT.Text = "Mạng máy tính và truyền thông";
            // 
            // radHTTT
            // 
            this.radHTTT.AutoSize = true;
            this.radHTTT.Location = new System.Drawing.Point(20, 115);
            this.radHTTT.Name = "radHTTT";
            this.radHTTT.Size = new System.Drawing.Size(113, 17);
            this.radHTTT.TabIndex = 3;
            this.radHTTT.Text = "Hệ thống thông tin";
            // 
            // grpNoiDung
            // 
            this.grpNoiDung.Controls.Add(this.txtNoiDung);
            this.grpNoiDung.Location = new System.Drawing.Point(330, 60);
            this.grpNoiDung.Name = "grpNoiDung";
            this.grpNoiDung.Size = new System.Drawing.Size(260, 300);
            this.grpNoiDung.TabIndex = 7;
            this.grpNoiDung.TabStop = false;
            this.grpNoiDung.Text = "Nội dung sinh viên đăng ký";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(15, 25);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(230, 260);
            this.txtNoiDung.TabIndex = 0;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(60, 380);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(100, 32);
            this.btnDangKy.TabIndex = 8;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(200, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // VD7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 430);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.grpNganhHoc);
            this.Controls.Add(this.grpNoiDung);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnThoat);
            this.Name = "VD7";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VD7_Load);
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            this.grpNganhHoc.ResumeLayout(false);
            this.grpNganhHoc.PerformLayout();
            this.grpNoiDung.ResumeLayout(false);
            this.grpNoiDung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox grpNganhHoc;
        private System.Windows.Forms.RadioButton radCNPM;
        private System.Windows.Forms.RadioButton radKTMT;
        private System.Windows.Forms.RadioButton radMMTTT;
        private System.Windows.Forms.RadioButton radHTTT;
        private System.Windows.Forms.GroupBox grpNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
    }
}