namespace LapTrinhWindowsForm.Chuong6.ViDu
{
    partial class VD3
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.myTabControl = new System.Windows.Forms.TabControl();
            this.tabQuanLyNhanVien = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChucVuNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLuongCBNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeSoLuongNV = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnCapNhatNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.listNhanVien = new System.Windows.Forms.ListView();
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLuongCoBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabQuanLyGiaoVien = new System.Windows.Forms.TabPage();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.lblHocVi = new System.Windows.Forms.Label();
            this.txtHocVi = new System.Windows.Forms.TextBox();
            this.lblTienDay = new System.Windows.Forms.Label();
            this.txtTienDayMotTiet = new System.Windows.Forms.TextBox();
            this.lblSoTietDay = new System.Windows.Forms.Label();
            this.txtSoTietDay = new System.Windows.Forms.TextBox();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.btnCapNhatGV = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.listGiaoVien = new System.Windows.Forms.ListView();
            this.colHoTenGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHocViGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTienDayGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoTietGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myTabControl.SuspendLayout();
            this.tabQuanLyNhanVien.SuspendLayout();
            this.tabQuanLyGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân sự";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(460, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // myTabControl
            // 
            this.myTabControl.Controls.Add(this.tabQuanLyNhanVien);
            this.myTabControl.Controls.Add(this.tabQuanLyGiaoVien);
            this.myTabControl.Location = new System.Drawing.Point(20, 60);
            this.myTabControl.Name = "myTabControl";
            this.myTabControl.SelectedIndex = 0;
            this.myTabControl.Size = new System.Drawing.Size(560, 340);
            this.myTabControl.TabIndex = 1;
            // 
            // tabQuanLyNhanVien
            // 
            this.tabQuanLyNhanVien.Controls.Add(this.label2);
            this.tabQuanLyNhanVien.Controls.Add(this.txtHoTenNV);
            this.tabQuanLyNhanVien.Controls.Add(this.label4);
            this.tabQuanLyNhanVien.Controls.Add(this.txtChucVuNV);
            this.tabQuanLyNhanVien.Controls.Add(this.label3);
            this.tabQuanLyNhanVien.Controls.Add(this.txtLuongCBNV);
            this.tabQuanLyNhanVien.Controls.Add(this.label5);
            this.tabQuanLyNhanVien.Controls.Add(this.txtHeSoLuongNV);
            this.tabQuanLyNhanVien.Controls.Add(this.btnThemNV);
            this.tabQuanLyNhanVien.Controls.Add(this.btnCapNhatNV);
            this.tabQuanLyNhanVien.Controls.Add(this.btnXoaNV);
            this.tabQuanLyNhanVien.Controls.Add(this.listNhanVien);
            this.tabQuanLyNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyNhanVien.Name = "tabQuanLyNhanVien";
            this.tabQuanLyNhanVien.Size = new System.Drawing.Size(552, 314);
            this.tabQuanLyNhanVien.TabIndex = 0;
            this.tabQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(110, 22);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(160, 20);
            this.txtHoTenNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chức vụ:";
            // 
            // txtChucVuNV
            // 
            this.txtChucVuNV.Location = new System.Drawing.Point(390, 22);
            this.txtChucVuNV.Name = "txtChucVuNV";
            this.txtChucVuNV.Size = new System.Drawing.Size(130, 20);
            this.txtChucVuNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lương cơ bản:";
            // 
            // txtLuongCBNV
            // 
            this.txtLuongCBNV.Location = new System.Drawing.Point(110, 62);
            this.txtLuongCBNV.Name = "txtLuongCBNV";
            this.txtLuongCBNV.Size = new System.Drawing.Size(160, 20);
            this.txtLuongCBNV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hệ số lương:";
            // 
            // txtHeSoLuongNV
            // 
            this.txtHeSoLuongNV.Location = new System.Drawing.Point(390, 62);
            this.txtHeSoLuongNV.Name = "txtHeSoLuongNV";
            this.txtHeSoLuongNV.Size = new System.Drawing.Size(130, 20);
            this.txtHeSoLuongNV.TabIndex = 7;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(20, 105);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(140, 30);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.Location = new System.Drawing.Point(200, 105);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(140, 30);
            this.btnCapNhatNV.TabIndex = 9;
            this.btnCapNhatNV.Text = "Cập nhật";
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(380, 105);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(140, 30);
            this.btnXoaNV.TabIndex = 10;
            this.btnXoaNV.Text = "Xóa nhân viên";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // listNhanVien
            // 
            this.listNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTen,
            this.colChucVu,
            this.colHeSoLuong,
            this.colLuongCoBan});
            this.listNhanVien.FullRowSelect = true;
            this.listNhanVien.HideSelection = false;
            this.listNhanVien.Location = new System.Drawing.Point(20, 150);
            this.listNhanVien.MultiSelect = false;
            this.listNhanVien.Name = "listNhanVien";
            this.listNhanVien.Size = new System.Drawing.Size(510, 160);
            this.listNhanVien.TabIndex = 11;
            this.listNhanVien.UseCompatibleStateImageBehavior = false;
            this.listNhanVien.View = System.Windows.Forms.View.Details;
            this.listNhanVien.SelectedIndexChanged += new System.EventHandler(this.listNhanVien_SelectedIndexChanged);
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 150;
            // 
            // colChucVu
            // 
            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.Width = 100;
            // 
            // colHeSoLuong
            // 
            this.colHeSoLuong.Text = "Hệ số lương";
            this.colHeSoLuong.Width = 100;
            // 
            // colLuongCoBan
            // 
            this.colLuongCoBan.Text = "Lương cơ bản";
            this.colLuongCoBan.Width = 120;
            // 
            // tabQuanLyGiaoVien
            // 
            this.tabQuanLyGiaoVien.Controls.Add(this.lblHoTenGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.txtHoTenGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.lblHocVi);
            this.tabQuanLyGiaoVien.Controls.Add(this.txtHocVi);
            this.tabQuanLyGiaoVien.Controls.Add(this.lblTienDay);
            this.tabQuanLyGiaoVien.Controls.Add(this.txtTienDayMotTiet);
            this.tabQuanLyGiaoVien.Controls.Add(this.lblSoTietDay);
            this.tabQuanLyGiaoVien.Controls.Add(this.txtSoTietDay);
            this.tabQuanLyGiaoVien.Controls.Add(this.btnThemGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.btnCapNhatGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.btnXoaGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.listGiaoVien);
            this.tabQuanLyGiaoVien.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyGiaoVien.Name = "tabQuanLyGiaoVien";
            this.tabQuanLyGiaoVien.Size = new System.Drawing.Size(552, 314);
            this.tabQuanLyGiaoVien.TabIndex = 1;
            this.tabQuanLyGiaoVien.Text = "Quản lý giáo viên";
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Location = new System.Drawing.Point(20, 25);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(42, 13);
            this.lblHoTenGV.TabIndex = 0;
            this.lblHoTenGV.Text = "Họ tên:";
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(110, 22);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(160, 20);
            this.txtHoTenGV.TabIndex = 1;
            // 
            // lblHocVi
            // 
            this.lblHocVi.AutoSize = true;
            this.lblHocVi.Location = new System.Drawing.Point(300, 25);
            this.lblHocVi.Name = "lblHocVi";
            this.lblHocVi.Size = new System.Drawing.Size(41, 13);
            this.lblHocVi.TabIndex = 2;
            this.lblHocVi.Text = "Học vị:";
            // 
            // txtHocVi
            // 
            this.txtHocVi.Location = new System.Drawing.Point(390, 22);
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(130, 20);
            this.txtHocVi.TabIndex = 3;
            // 
            // lblTienDay
            // 
            this.lblTienDay.AutoSize = true;
            this.lblTienDay.Location = new System.Drawing.Point(20, 65);
            this.lblTienDay.Name = "lblTienDay";
            this.lblTienDay.Size = new System.Drawing.Size(88, 13);
            this.lblTienDay.TabIndex = 4;
            this.lblTienDay.Text = "Tiền dạy một tiết:";
            // 
            // txtTienDayMotTiet
            // 
            this.txtTienDayMotTiet.Location = new System.Drawing.Point(140, 62);
            this.txtTienDayMotTiet.Name = "txtTienDayMotTiet";
            this.txtTienDayMotTiet.Size = new System.Drawing.Size(130, 20);
            this.txtTienDayMotTiet.TabIndex = 5;
            // 
            // lblSoTietDay
            // 
            this.lblSoTietDay.AutoSize = true;
            this.lblSoTietDay.Location = new System.Drawing.Point(300, 65);
            this.lblSoTietDay.Name = "lblSoTietDay";
            this.lblSoTietDay.Size = new System.Drawing.Size(60, 13);
            this.lblSoTietDay.TabIndex = 6;
            this.lblSoTietDay.Text = "Số tiết dạy:";
            // 
            // txtSoTietDay
            // 
            this.txtSoTietDay.Location = new System.Drawing.Point(390, 62);
            this.txtSoTietDay.Name = "txtSoTietDay";
            this.txtSoTietDay.Size = new System.Drawing.Size(130, 20);
            this.txtSoTietDay.TabIndex = 7;
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(20, 105);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(140, 30);
            this.btnThemGV.TabIndex = 8;
            this.btnThemGV.Text = "Thêm giáo viên";
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnCapNhatGV
            // 
            this.btnCapNhatGV.Location = new System.Drawing.Point(200, 105);
            this.btnCapNhatGV.Name = "btnCapNhatGV";
            this.btnCapNhatGV.Size = new System.Drawing.Size(140, 30);
            this.btnCapNhatGV.TabIndex = 9;
            this.btnCapNhatGV.Text = "Cập nhật";
            this.btnCapNhatGV.Click += new System.EventHandler(this.btnCapNhatGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Location = new System.Drawing.Point(380, 105);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(140, 30);
            this.btnXoaGV.TabIndex = 10;
            this.btnXoaGV.Text = "Xóa giáo viên";
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // listGiaoVien
            // 
            this.listGiaoVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTenGV,
            this.colHocViGV,
            this.colTienDayGV,
            this.colSoTietGV});
            this.listGiaoVien.FullRowSelect = true;
            this.listGiaoVien.HideSelection = false;
            this.listGiaoVien.Location = new System.Drawing.Point(20, 150);
            this.listGiaoVien.MultiSelect = false;
            this.listGiaoVien.Name = "listGiaoVien";
            this.listGiaoVien.Size = new System.Drawing.Size(510, 160);
            this.listGiaoVien.TabIndex = 11;
            this.listGiaoVien.UseCompatibleStateImageBehavior = false;
            this.listGiaoVien.View = System.Windows.Forms.View.Details;
            this.listGiaoVien.SelectedIndexChanged += new System.EventHandler(this.listGiaoVien_SelectedIndexChanged);
            // 
            // colHoTenGV
            // 
            this.colHoTenGV.Text = "Họ tên";
            this.colHoTenGV.Width = 150;
            // 
            // colHocViGV
            // 
            this.colHocViGV.Text = "Học vị";
            this.colHocViGV.Width = 100;
            // 
            // colTienDayGV
            // 
            this.colTienDayGV.Text = "Tiền dạy một tiết";
            this.colTienDayGV.Width = 130;
            // 
            // colSoTietGV
            // 
            this.colSoTietGV.Text = "Số tiết dạy";
            this.colSoTietGV.Width = 100;
            // 
            // VD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myTabControl);
            this.Controls.Add(this.btnThoat);
            this.Name = "VD3";
            this.Text = "TabControl";
            this.myTabControl.ResumeLayout(false);
            this.tabQuanLyNhanVien.ResumeLayout(false);
            this.tabQuanLyNhanVien.PerformLayout();
            this.tabQuanLyGiaoVien.ResumeLayout(false);
            this.tabQuanLyGiaoVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TabControl myTabControl;

        private System.Windows.Forms.TabPage tabQuanLyNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChucVuNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLuongCBNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeSoLuongNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnCapNhatNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.ListView listNhanVien;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colHeSoLuong;
        private System.Windows.Forms.ColumnHeader colLuongCoBan;

        private System.Windows.Forms.TabPage tabQuanLyGiaoVien;
        private System.Windows.Forms.Label lblHoTenGV;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.Label lblHocVi;
        private System.Windows.Forms.TextBox txtHocVi;
        private System.Windows.Forms.Label lblTienDay;
        private System.Windows.Forms.TextBox txtTienDayMotTiet;
        private System.Windows.Forms.Label lblSoTietDay;
        private System.Windows.Forms.TextBox txtSoTietDay;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.Button btnCapNhatGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.ListView listGiaoVien;
        private System.Windows.Forms.ColumnHeader colHoTenGV;
        private System.Windows.Forms.ColumnHeader colHocViGV;
        private System.Windows.Forms.ColumnHeader colTienDayGV;
        private System.Windows.Forms.ColumnHeader colSoTietGV;
    }
}