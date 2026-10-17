namespace LapTrinhWindowsForm.Chuong3.BaiTap
{
    partial class BT5
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnPhanTich = new System.Windows.Forms.Button();
            this.lblKetQuaTieuDe = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(380, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Phân tích thừa số nguyên tố";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Location = new System.Drawing.Point(30, 75);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(93, 13);
            this.lblNhapSo.TabIndex = 1;
            this.lblNhapSo.Text = "Nhập số cần tính:";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(170, 72);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(180, 20);
            this.txtSo.TabIndex = 2;
            // 
            // btnPhanTich
            // 
            this.btnPhanTich.Location = new System.Drawing.Point(170, 115);
            this.btnPhanTich.Name = "btnPhanTich";
            this.btnPhanTich.Size = new System.Drawing.Size(140, 32);
            this.btnPhanTich.TabIndex = 3;
            this.btnPhanTich.Text = "Phân tích";
            this.btnPhanTich.Click += new System.EventHandler(this.btnPhanTich_Click);
            // 
            // lblKetQuaTieuDe
            // 
            this.lblKetQuaTieuDe.AutoSize = true;
            this.lblKetQuaTieuDe.Location = new System.Drawing.Point(30, 175);
            this.lblKetQuaTieuDe.Name = "lblKetQuaTieuDe";
            this.lblKetQuaTieuDe.Size = new System.Drawing.Size(47, 13);
            this.lblKetQuaTieuDe.TabIndex = 4;
            this.lblKetQuaTieuDe.Text = "Kết quả:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKetQua.Location = new System.Drawing.Point(170, 172);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(180, 25);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 230);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.btnPhanTich);
            this.Controls.Add(this.lblKetQuaTieuDe);
            this.Controls.Add(this.lblKetQua);
            this.Name = "BT5";
            this.Text = "Bài tập";
            this.Load += new System.EventHandler(this.BT5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnPhanTich;
        private System.Windows.Forms.Label lblKetQuaTieuDe;
        private System.Windows.Forms.Label lblKetQua;
    }
}