namespace LapTrinhWindowsForm.Chuong2
{
    partial class TracNghiem
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
            this.lblSoThuTu = new System.Windows.Forms.Label();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.lblDapAn1 = new System.Windows.Forms.Label();
            this.lblDapAn2 = new System.Windows.Forms.Label();
            this.lblDapAn3 = new System.Windows.Forms.Label();
            this.lblDapAn4 = new System.Windows.Forms.Label();
            this.lblDapAn5 = new System.Windows.Forms.Label();
            this.lblDapAn6 = new System.Windows.Forms.Label();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnCauTiep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoThuTu
            // 
            this.lblSoThuTu.AutoSize = true;
            this.lblSoThuTu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoThuTu.Location = new System.Drawing.Point(30, 20);
            this.lblSoThuTu.Name = "lblSoThuTu";
            this.lblSoThuTu.Size = new System.Drawing.Size(60, 19);
            this.lblSoThuTu.TabIndex = 0;
            this.lblSoThuTu.Text = "Câu 1/5";
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCauHoi.Location = new System.Drawing.Point(30, 55);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(500, 50);
            this.lblCauHoi.TabIndex = 1;
            // 
            // lblDapAn1
            // 
            this.lblDapAn1.AutoSize = true;
            this.lblDapAn1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDapAn1.Location = new System.Drawing.Point(50, 120);
            this.lblDapAn1.Name = "lblDapAn1";
            this.lblDapAn1.Size = new System.Drawing.Size(0, 19);
            this.lblDapAn1.TabIndex = 2;
            // 
            // lblDapAn2
            // 
            this.lblDapAn2.AutoSize = true;
            this.lblDapAn2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDapAn2.Location = new System.Drawing.Point(50, 150);
            this.lblDapAn2.Name = "lblDapAn2";
            this.lblDapAn2.Size = new System.Drawing.Size(0, 19);
            this.lblDapAn2.TabIndex = 3;
            // 
            // lblDapAn3
            // 
            this.lblDapAn3.AutoSize = true;
            this.lblDapAn3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDapAn3.Location = new System.Drawing.Point(50, 180);
            this.lblDapAn3.Name = "lblDapAn3";
            this.lblDapAn3.Size = new System.Drawing.Size(0, 19);
            this.lblDapAn3.TabIndex = 4;
            // 
            // lblDapAn4
            // 
            this.lblDapAn4.AutoSize = true;
            this.lblDapAn4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDapAn4.Location = new System.Drawing.Point(50, 210);
            this.lblDapAn4.Name = "lblDapAn4";
            this.lblDapAn4.Size = new System.Drawing.Size(0, 19);
            this.lblDapAn4.TabIndex = 5;
            // 
            // lblDapAn5
            // 
            this.lblDapAn5.AutoSize = true;
            this.lblDapAn5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDapAn5.Location = new System.Drawing.Point(50, 240);
            this.lblDapAn5.Name = "lblDapAn5";
            this.lblDapAn5.Size = new System.Drawing.Size(0, 19);
            this.lblDapAn5.TabIndex = 6;
            // 
            // lblDapAn6
            // 
            this.lblDapAn6.AutoSize = true;
            this.lblDapAn6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDapAn6.Location = new System.Drawing.Point(50, 270);
            this.lblDapAn6.Name = "lblDapAn6";
            this.lblDapAn6.Size = new System.Drawing.Size(0, 19);
            this.lblDapAn6.TabIndex = 7;
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCauTruoc.ForeColor = System.Drawing.Color.Blue;
            this.btnCauTruoc.Location = new System.Drawing.Point(50, 320);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(110, 35);
            this.btnCauTruoc.TabIndex = 8;
            this.btnCauTruoc.Text = "Câu trước";
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // btnCauTiep
            // 
            this.btnCauTiep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCauTiep.ForeColor = System.Drawing.Color.Blue;
            this.btnCauTiep.Location = new System.Drawing.Point(180, 320);
            this.btnCauTiep.Name = "btnCauTiep";
            this.btnCauTiep.Size = new System.Drawing.Size(110, 35);
            this.btnCauTiep.TabIndex = 9;
            this.btnCauTiep.Text = "Câu tiếp";
            this.btnCauTiep.Click += new System.EventHandler(this.btnCauTiep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(420, 320);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 35);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 390);
            this.Controls.Add(this.lblSoThuTu);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.lblDapAn1);
            this.Controls.Add(this.lblDapAn2);
            this.Controls.Add(this.lblDapAn3);
            this.Controls.Add(this.lblDapAn4);
            this.Controls.Add(this.lblDapAn5);
            this.Controls.Add(this.lblDapAn6);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.btnCauTiep);
            this.Controls.Add(this.btnThoat);
            this.Name = "TracNghiem";
            this.Text = "Trắc nghiệm Chương 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoThuTu;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label lblDapAn1;
        private System.Windows.Forms.Label lblDapAn2;
        private System.Windows.Forms.Label lblDapAn3;
        private System.Windows.Forms.Label lblDapAn4;
        private System.Windows.Forms.Label lblDapAn5;
        private System.Windows.Forms.Label lblDapAn6;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnCauTiep;
        private System.Windows.Forms.Button btnThoat;
    }
}