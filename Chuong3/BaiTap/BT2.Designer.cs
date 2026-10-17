namespace LapTrinhWindowsForm.Chuong3.BaiTap
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
            this.lblNhapChuoi = new System.Windows.Forms.Label();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lstKetQua = new System.Windows.Forms.ListBox();
            this.btnDemSoTu = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(460, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thống kê tần suất xuất hiện của từ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapChuoi
            // 
            this.lblNhapChuoi.AutoSize = true;
            this.lblNhapChuoi.Location = new System.Drawing.Point(30, 65);
            this.lblNhapChuoi.Name = "lblNhapChuoi";
            this.lblNhapChuoi.Size = new System.Drawing.Size(65, 13);
            this.lblNhapChuoi.TabIndex = 1;
            this.lblNhapChuoi.Text = "Nhập chuỗi:";
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(30, 90);
            this.txtChuoi.Multiline = true;
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(240, 180);
            this.txtChuoi.TabIndex = 2;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(300, 65);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(89, 13);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "Kết quả thống kê";
            // 
            // lstKetQua
            // 
            this.lstKetQua.Location = new System.Drawing.Point(300, 90);
            this.lstKetQua.Name = "lstKetQua";
            this.lstKetQua.Size = new System.Drawing.Size(190, 173);
            this.lstKetQua.TabIndex = 4;
            // 
            // btnDemSoTu
            // 
            this.btnDemSoTu.Location = new System.Drawing.Point(30, 285);
            this.btnDemSoTu.Name = "btnDemSoTu";
            this.btnDemSoTu.Size = new System.Drawing.Size(110, 32);
            this.btnDemSoTu.TabIndex = 5;
            this.btnDemSoTu.Text = "Đếm số từ";
            this.btnDemSoTu.Click += new System.EventHandler(this.btnDemSoTu_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(160, 285);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(110, 32);
            this.btnTiepTuc.TabIndex = 6;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // BT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 340);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblNhapChuoi);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lstKetQua);
            this.Controls.Add(this.btnDemSoTu);
            this.Controls.Add(this.btnTiepTuc);
            this.Name = "BT2";
            this.Text = "Bài tập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhapChuoi;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.ListBox lstKetQua;
        private System.Windows.Forms.Button btnDemSoTu;
        private System.Windows.Forms.Button btnTiepTuc;
    }
}