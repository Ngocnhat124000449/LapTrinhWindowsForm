namespace LapTrinhWindowsForm.LamQuen
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
            this.lblChieuDai = new System.Windows.Forms.Label();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChieuDai
            // 
            this.lblChieuDai.AutoSize = true;
            this.lblChieuDai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChieuDai.ForeColor = System.Drawing.Color.Navy;
            this.lblChieuDai.Location = new System.Drawing.Point(30, 40);
            this.lblChieuDai.Name = "lblChieuDai";
            this.lblChieuDai.Size = new System.Drawing.Size(59, 15);
            this.lblChieuDai.TabIndex = 0;
            this.lblChieuDai.Text = "Chiều Dài";
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChieuRong.ForeColor = System.Drawing.Color.Navy;
            this.lblChieuRong.Location = new System.Drawing.Point(30, 90);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(67, 15);
            this.lblChieuRong.TabIndex = 1;
            this.lblChieuRong.Text = "Chiều rộng";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChuVi.ForeColor = System.Drawing.Color.Navy;
            this.lblChuVi.Location = new System.Drawing.Point(30, 140);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(41, 15);
            this.lblChuVi.TabIndex = 2;
            this.lblChuVi.Text = "Chu vi";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDienTich.ForeColor = System.Drawing.Color.Navy;
            this.lblDienTich.Location = new System.Drawing.Point(30, 190);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(57, 15);
            this.lblDienTich.TabIndex = 3;
            this.lblDienTich.Text = "Diên tích";
            // 
            // txtCD
            // 
            this.txtCD.Location = new System.Drawing.Point(140, 37);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(150, 20);
            this.txtCD.TabIndex = 4;
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(140, 87);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(150, 20);
            this.txtCR.TabIndex = 5;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(140, 137);
            this.txtCV.Name = "txtCV";
            this.txtCV.ReadOnly = true;
            this.txtCV.Size = new System.Drawing.Size(150, 20);
            this.txtCV.TabIndex = 6;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(140, 187);
            this.txtDT.Name = "txtDT";
            this.txtDT.ReadOnly = true;
            this.txtDT.Size = new System.Drawing.Size(150, 20);
            this.txtDT.TabIndex = 7;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTinh.ForeColor = System.Drawing.Color.Red;
            this.btnTinh.Location = new System.Drawing.Point(330, 37);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 35);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "Tính";
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(330, 87);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // VD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.lblChieuDai);
            this.Controls.Add(this.lblChieuRong);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.txtCD);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnThoat);
            this.Name = "VD1";
            this.Text = "Hình chữ nhật";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChieuDai;
        private System.Windows.Forms.Label lblChieuRong;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
    }
}