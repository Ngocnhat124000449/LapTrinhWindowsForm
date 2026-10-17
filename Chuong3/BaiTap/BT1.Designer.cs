namespace LapTrinhWindowsForm.Chuong3.BaiTap
{
    partial class BT1
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
            this.btnDemSoTu = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.lblSoTuCo = new System.Windows.Forms.Label();
            this.txtSoTu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(360, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐẾM SỐ TỪ TRONG CHUỖI";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapChuoi
            // 
            this.lblNhapChuoi.AutoSize = true;
            this.lblNhapChuoi.Location = new System.Drawing.Point(30, 70);
            this.lblNhapChuoi.Name = "lblNhapChuoi";
            this.lblNhapChuoi.Size = new System.Drawing.Size(65, 13);
            this.lblNhapChuoi.TabIndex = 1;
            this.lblNhapChuoi.Text = "Nhập chuỗi:";
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(130, 60);
            this.txtChuoi.Multiline = true;
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(260, 90);
            this.txtChuoi.TabIndex = 2;
            // 
            // btnDemSoTu
            // 
            this.btnDemSoTu.Location = new System.Drawing.Point(130, 160);
            this.btnDemSoTu.Name = "btnDemSoTu";
            this.btnDemSoTu.Size = new System.Drawing.Size(110, 32);
            this.btnDemSoTu.TabIndex = 3;
            this.btnDemSoTu.Text = "Đếm số từ";
            this.btnDemSoTu.Click += new System.EventHandler(this.btnDemSoTu_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(260, 160);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(110, 32);
            this.btnTiepTuc.TabIndex = 4;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // lblSoTuCo
            // 
            this.lblSoTuCo.AutoSize = true;
            this.lblSoTuCo.Location = new System.Drawing.Point(30, 210);
            this.lblSoTuCo.Name = "lblSoTuCo";
            this.lblSoTuCo.Size = new System.Drawing.Size(76, 13);
            this.lblSoTuCo.TabIndex = 5;
            this.lblSoTuCo.Text = "Số từ chuỗi có";
            // 
            // txtSoTu
            // 
            this.txtSoTu.Location = new System.Drawing.Point(160, 207);
            this.txtSoTu.Name = "txtSoTu";
            this.txtSoTu.ReadOnly = true;
            this.txtSoTu.Size = new System.Drawing.Size(80, 20);
            this.txtSoTu.TabIndex = 6;
            this.txtSoTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblNhapChuoi);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.btnDemSoTu);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.lblSoTuCo);
            this.Controls.Add(this.txtSoTu);
            this.Name = "BT1";
            this.Text = "Bài tập";
            this.Load += new System.EventHandler(this.BT1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhapChuoi;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Button btnDemSoTu;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Label lblSoTuCo;
        private System.Windows.Forms.TextBox txtSoTu;
    }
}