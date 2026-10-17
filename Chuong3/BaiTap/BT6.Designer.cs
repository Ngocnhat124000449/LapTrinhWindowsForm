namespace LapTrinhWindowsForm.Chuong3.BaiTap
{
    partial class BT6
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
            this.lblDanhSachMonAn = new System.Windows.Forms.Label();
            this.lstMonAn = new System.Windows.Forms.ListBox();
            this.lblDanhSachThucDon = new System.Windows.Forms.Label();
            this.lstThucDon = new System.Windows.Forms.ListBox();
            this.btnChuyenMot = new System.Windows.Forms.Button();
            this.btnTraMot = new System.Windows.Forms.Button();
            this.btnChuyenTatCa = new System.Windows.Forms.Button();
            this.btnTraTatCa = new System.Windows.Forms.Button();
            this.btnInThucDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(520, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thực đơn trong ngày";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDanhSachMonAn
            // 
            this.lblDanhSachMonAn.AutoSize = true;
            this.lblDanhSachMonAn.Location = new System.Drawing.Point(30, 70);
            this.lblDanhSachMonAn.Name = "lblDanhSachMonAn";
            this.lblDanhSachMonAn.Size = new System.Drawing.Size(97, 13);
            this.lblDanhSachMonAn.TabIndex = 1;
            this.lblDanhSachMonAn.Text = "Danh sách món ăn";
            // 
            // lstMonAn
            // 
            this.lstMonAn.Items.AddRange(new object[] {
            "Bò kho",
            "Phở bò",
            "Phở gà",
            "Bún măng",
            "Bún bò",
            "Bún riêu",
            "Mì xào thập cẩm",
            "Mì xào bò",
            "Mì xào chay"});
            this.lstMonAn.Location = new System.Drawing.Point(30, 95);
            this.lstMonAn.Name = "lstMonAn";
            this.lstMonAn.Size = new System.Drawing.Size(200, 212);
            this.lstMonAn.TabIndex = 2;
            // 
            // lblDanhSachThucDon
            // 
            this.lblDanhSachThucDon.AutoSize = true;
            this.lblDanhSachThucDon.Location = new System.Drawing.Point(330, 70);
            this.lblDanhSachThucDon.Name = "lblDanhSachThucDon";
            this.lblDanhSachThucDon.Size = new System.Drawing.Size(131, 13);
            this.lblDanhSachThucDon.TabIndex = 3;
            this.lblDanhSachThucDon.Text = "Danh sách thực đơn ngày";
            // 
            // lstThucDon
            // 
            this.lstThucDon.Location = new System.Drawing.Point(330, 95);
            this.lstThucDon.Name = "lstThucDon";
            this.lstThucDon.Size = new System.Drawing.Size(200, 212);
            this.lstThucDon.TabIndex = 4;
            // 
            // btnChuyenMot
            // 
            this.btnChuyenMot.Location = new System.Drawing.Point(250, 130);
            this.btnChuyenMot.Name = "btnChuyenMot";
            this.btnChuyenMot.Size = new System.Drawing.Size(60, 30);
            this.btnChuyenMot.TabIndex = 5;
            this.btnChuyenMot.Text = ">";
            this.btnChuyenMot.Click += new System.EventHandler(this.btnChuyenMot_Click);
            // 
            // btnTraMot
            // 
            this.btnTraMot.Location = new System.Drawing.Point(250, 170);
            this.btnTraMot.Name = "btnTraMot";
            this.btnTraMot.Size = new System.Drawing.Size(60, 30);
            this.btnTraMot.TabIndex = 6;
            this.btnTraMot.Text = "<";
            this.btnTraMot.Click += new System.EventHandler(this.btnTraMot_Click);
            // 
            // btnChuyenTatCa
            // 
            this.btnChuyenTatCa.Location = new System.Drawing.Point(250, 210);
            this.btnChuyenTatCa.Name = "btnChuyenTatCa";
            this.btnChuyenTatCa.Size = new System.Drawing.Size(60, 30);
            this.btnChuyenTatCa.TabIndex = 7;
            this.btnChuyenTatCa.Text = ">>";
            this.btnChuyenTatCa.Click += new System.EventHandler(this.btnChuyenTatCa_Click);
            // 
            // btnTraTatCa
            // 
            this.btnTraTatCa.Location = new System.Drawing.Point(250, 250);
            this.btnTraTatCa.Name = "btnTraTatCa";
            this.btnTraTatCa.Size = new System.Drawing.Size(60, 30);
            this.btnTraTatCa.TabIndex = 8;
            this.btnTraTatCa.Text = "<<";
            this.btnTraTatCa.Click += new System.EventHandler(this.btnTraTatCa_Click);
            // 
            // btnInThucDon
            // 
            this.btnInThucDon.Location = new System.Drawing.Point(150, 335);
            this.btnInThucDon.Name = "btnInThucDon";
            this.btnInThucDon.Size = new System.Drawing.Size(120, 32);
            this.btnInThucDon.TabIndex = 9;
            this.btnInThucDon.Text = "In thực đơn";
            this.btnInThucDon.Click += new System.EventHandler(this.btnInThucDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(300, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 32);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // BT6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblDanhSachMonAn);
            this.Controls.Add(this.lstMonAn);
            this.Controls.Add(this.lblDanhSachThucDon);
            this.Controls.Add(this.lstThucDon);
            this.Controls.Add(this.btnChuyenMot);
            this.Controls.Add(this.btnTraMot);
            this.Controls.Add(this.btnChuyenTatCa);
            this.Controls.Add(this.btnTraTatCa);
            this.Controls.Add(this.btnInThucDon);
            this.Controls.Add(this.btnThoat);
            this.Name = "BT6";
            this.Text = "Bài tập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDanhSachMonAn;
        private System.Windows.Forms.ListBox lstMonAn;
        private System.Windows.Forms.Label lblDanhSachThucDon;
        private System.Windows.Forms.ListBox lstThucDon;
        private System.Windows.Forms.Button btnChuyenMot;
        private System.Windows.Forms.Button btnTraMot;
        private System.Windows.Forms.Button btnChuyenTatCa;
        private System.Windows.Forms.Button btnTraTatCa;
        private System.Windows.Forms.Button btnInThucDon;
        private System.Windows.Forms.Button btnThoat;
    }
}