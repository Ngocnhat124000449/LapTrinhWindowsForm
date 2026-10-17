namespace LapTrinhWindowsForm.Chuong3.BaiTap
{
    partial class BT4
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
            this.lblNhapDaySo = new System.Windows.Forms.Label();
            this.txtDaySo = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
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
            this.lblTieuDe.Size = new System.Drawing.Size(420, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Tìm số chính phương";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapDaySo
            // 
            this.lblNhapDaySo.AutoSize = true;
            this.lblNhapDaySo.Location = new System.Drawing.Point(30, 75);
            this.lblNhapDaySo.Name = "lblNhapDaySo";
            this.lblNhapDaySo.Size = new System.Drawing.Size(70, 13);
            this.lblNhapDaySo.TabIndex = 1;
            this.lblNhapDaySo.Text = "Nhập dãy số:";
            // 
            // txtDaySo
            // 
            this.txtDaySo.Location = new System.Drawing.Point(150, 72);
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.Size = new System.Drawing.Size(300, 20);
            this.txtDaySo.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(150, 120);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 32);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(280, 120);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblKetQuaTieuDe
            // 
            this.lblKetQuaTieuDe.AutoSize = true;
            this.lblKetQuaTieuDe.Location = new System.Drawing.Point(30, 175);
            this.lblKetQuaTieuDe.Name = "lblKetQuaTieuDe";
            this.lblKetQuaTieuDe.Size = new System.Drawing.Size(186, 13);
            this.lblKetQuaTieuDe.TabIndex = 5;
            this.lblKetQuaTieuDe.Text = "Các số chính phương có trong dãy là:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.Location = new System.Drawing.Point(30, 205);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(420, 25);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblNhapDaySo);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblKetQuaTieuDe);
            this.Controls.Add(this.lblKetQua);
            this.Name = "BT4";
            this.Text = "Bài tập";
            this.Load += new System.EventHandler(this.BT4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhapDaySo;
        private System.Windows.Forms.TextBox txtDaySo;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblKetQuaTieuDe;
        private System.Windows.Forms.Label lblKetQua;
    }
}