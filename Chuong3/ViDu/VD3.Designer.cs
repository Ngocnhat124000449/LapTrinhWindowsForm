namespace LapTrinhWindowsForm.Chuong3.ViDu
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
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblNhapChuoi = new System.Windows.Forms.Label();
            this.txtChuoiCanTim = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(30, 40);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(53, 13);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(110, 30);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(280, 80);
            this.txtNoiDung.TabIndex = 1;
            this.txtNoiDung.Text = "Quả cau nho nhỏ miếng trầu cay\r\nNày của Xuân Hương đã quệt rồi\r\nCó phải duyên nha" +
    "u thì thắm lại\r\nĐừng xanh như lá bạc như vôi";
            // 
            // lblNhapChuoi
            // 
            this.lblNhapChuoi.AutoSize = true;
            this.lblNhapChuoi.Location = new System.Drawing.Point(30, 140);
            this.lblNhapChuoi.Name = "lblNhapChuoi";
            this.lblNhapChuoi.Size = new System.Drawing.Size(65, 13);
            this.lblNhapChuoi.TabIndex = 2;
            this.lblNhapChuoi.Text = "Nhập chuỗi:";
            // 
            // txtChuoiCanTim
            // 
            this.txtChuoiCanTim.Location = new System.Drawing.Point(110, 137);
            this.txtChuoiCanTim.Name = "txtChuoiCanTim";
            this.txtChuoiCanTim.Size = new System.Drawing.Size(160, 20);
            this.txtChuoiCanTim.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(280, 135);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 30);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(420, 40);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 80);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // VD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 200);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblNhapChuoi);
            this.Controls.Add(this.txtChuoiCanTim);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Name = "VD3";
            this.Text = "Giao diện Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblNhapChuoi;
        private System.Windows.Forms.TextBox txtChuoiCanTim;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}