namespace LapTrinhWindowsForm.Chuong3.ViDu
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTieuDe (Bước 3: Font Microsoft Sans Serif, Bold, 18; ForeColor Red — hình 3.4, 3.5, 3.6)
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Text = "KHOA CÔNG NGHỆ THÔNG TIN";

            // lblMaSV (Bước 4: Font Oblique, 12, Underline — hình 3.8, 3.9)
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            // Oblique trong Designer tương ứng FontStyle.Italic ở code
            this.lblMaSV.Location = new System.Drawing.Point(30, 90);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Text = "Mã sinh viên: 111000111";

            // lblHoTen (hình 3.10)
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblHoTen.Location = new System.Drawing.Point(30, 120);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Text = "Họ tên: Trần Văn A";

            // lblLop (hình 3.11)
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblLop.Location = new System.Drawing.Point(30, 150);
            this.lblLop.Name = "lblLop";
            this.lblLop.Text = "Lớp: 13CT111";

            // lblMail (hình 3.12)
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblMail.Location = new System.Drawing.Point(30, 180);
            this.lblMail.Name = "lblMail";
            this.lblMail.Text = "Mail: TVA@gmail.com";

            // lblDienThoai (hình 3.13)
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblDienThoai.Location = new System.Drawing.Point(30, 210);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Text = "Điện thoại: 0613.813342";

            // VD1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 270);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDienThoai);
            this.Name = "VD1";
            this.Text = "Giao diện Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDienThoai;
    }
}