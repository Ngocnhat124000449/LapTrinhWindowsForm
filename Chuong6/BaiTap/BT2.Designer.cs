namespace LapTrinhWindowsForm.Chuong6.BaiTap
{
    partial class BT2
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
            this.grpCauHoi = new System.Windows.Forms.GroupBox();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.grpDapAn = new System.Windows.Forms.GroupBox();
            this.lblNoiDungDapAn = new System.Windows.Forms.Label();
            this.txtDapAn = new System.Windows.Forms.TextBox();
            this.chkDapAnDung = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lvDapAn = new System.Windows.Forms.ListView();
            this.colNoiDungDapAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDapAnDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpCauHoi.SuspendLayout();
            this.grpDapAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(460, 35);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Tạo câu hỏi trắc nghiệm";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCauHoi
            // 
            this.grpCauHoi.Controls.Add(this.txtCauHoi);
            this.grpCauHoi.Location = new System.Drawing.Point(20, 60);
            this.grpCauHoi.Name = "grpCauHoi";
            this.grpCauHoi.Size = new System.Drawing.Size(420, 90);
            this.grpCauHoi.TabIndex = 1;
            this.grpCauHoi.TabStop = false;
            this.grpCauHoi.Text = "Nhập nội dung câu hỏi";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Location = new System.Drawing.Point(15, 25);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(390, 50);
            this.txtCauHoi.TabIndex = 0;
            // 
            // grpDapAn
            // 
            this.grpDapAn.Controls.Add(this.lblNoiDungDapAn);
            this.grpDapAn.Controls.Add(this.txtDapAn);
            this.grpDapAn.Controls.Add(this.chkDapAnDung);
            this.grpDapAn.Controls.Add(this.btnThem);
            this.grpDapAn.Controls.Add(this.lvDapAn);
            this.grpDapAn.Location = new System.Drawing.Point(20, 160);
            this.grpDapAn.Name = "grpDapAn";
            this.grpDapAn.Size = new System.Drawing.Size(420, 240);
            this.grpDapAn.TabIndex = 2;
            this.grpDapAn.TabStop = false;
            this.grpDapAn.Text = "Nhập đáp án";
            // 
            // lblNoiDungDapAn
            // 
            this.lblNoiDungDapAn.AutoSize = true;
            this.lblNoiDungDapAn.Location = new System.Drawing.Point(15, 30);
            this.lblNoiDungDapAn.Name = "lblNoiDungDapAn";
            this.lblNoiDungDapAn.Size = new System.Drawing.Size(87, 13);
            this.lblNoiDungDapAn.TabIndex = 0;
            this.lblNoiDungDapAn.Text = "Nội dung đáp án";
            // 
            // txtDapAn
            // 
            this.txtDapAn.Location = new System.Drawing.Point(140, 27);
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.Size = new System.Drawing.Size(180, 20);
            this.txtDapAn.TabIndex = 1;
            // 
            // chkDapAnDung
            // 
            this.chkDapAnDung.AutoSize = true;
            this.chkDapAnDung.Location = new System.Drawing.Point(140, 60);
            this.chkDapAnDung.Name = "chkDapAnDung";
            this.chkDapAnDung.Size = new System.Drawing.Size(89, 17);
            this.chkDapAnDung.TabIndex = 2;
            this.chkDapAnDung.Text = "Đáp án đúng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(330, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 27);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lvDapAn
            // 
            this.lvDapAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNoiDungDapAn,
            this.colDapAnDung});
            this.lvDapAn.FullRowSelect = true;
            this.lvDapAn.GridLines = true;
            this.lvDapAn.HideSelection = false;
            this.lvDapAn.Location = new System.Drawing.Point(15, 95);
            this.lvDapAn.Name = "lvDapAn";
            this.lvDapAn.Size = new System.Drawing.Size(390, 130);
            this.lvDapAn.TabIndex = 4;
            this.lvDapAn.UseCompatibleStateImageBehavior = false;
            this.lvDapAn.View = System.Windows.Forms.View.Details;
            // 
            // colNoiDungDapAn
            // 
            this.colNoiDungDapAn.Text = "Nội dung đáp án";
            this.colNoiDungDapAn.Width = 250;
            // 
            // colDapAnDung
            // 
            this.colDapAnDung.Text = "Đáp án đúng";
            this.colDapAnDung.Width = 120;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Location = new System.Drawing.Point(140, 415);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(120, 32);
            this.btnHoanThanh.TabIndex = 3;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(280, 415);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // BT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 470);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpCauHoi);
            this.Controls.Add(this.grpDapAn);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.btnThoat);
            this.Name = "BT2";
            this.Text = "Bài tập";
            this.grpCauHoi.ResumeLayout(false);
            this.grpCauHoi.PerformLayout();
            this.grpDapAn.ResumeLayout(false);
            this.grpDapAn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpCauHoi;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.GroupBox grpDapAn;
        private System.Windows.Forms.Label lblNoiDungDapAn;
        private System.Windows.Forms.TextBox txtDapAn;
        private System.Windows.Forms.CheckBox chkDapAnDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lvDapAn;
        private System.Windows.Forms.ColumnHeader colNoiDungDapAn;
        private System.Windows.Forms.ColumnHeader colDapAnDung;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Button btnThoat;
    }
}