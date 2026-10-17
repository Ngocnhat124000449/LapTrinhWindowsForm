namespace LapTrinhWindowsForm.Chuong3.BaiTap
{
    partial class BT3
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
            this.lblHeSoA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblHeSoB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblHeSoC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblNghiemTieuDe = new System.Windows.Forms.Label();
            this.lblNghiem = new System.Windows.Forms.Label();
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
            this.lblTieuDe.Text = "Giải phương trình bậc hai";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeSoA
            // 
            this.lblHeSoA.AutoSize = true;
            this.lblHeSoA.Location = new System.Drawing.Point(30, 70);
            this.lblHeSoA.Name = "lblHeSoA";
            this.lblHeSoA.Size = new System.Drawing.Size(74, 13);
            this.lblHeSoA.TabIndex = 1;
            this.lblHeSoA.Text = "Nhập hệ số a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(150, 67);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 20);
            this.txtA.TabIndex = 2;
            // 
            // lblHeSoB
            // 
            this.lblHeSoB.AutoSize = true;
            this.lblHeSoB.Location = new System.Drawing.Point(30, 105);
            this.lblHeSoB.Name = "lblHeSoB";
            this.lblHeSoB.Size = new System.Drawing.Size(74, 13);
            this.lblHeSoB.TabIndex = 3;
            this.lblHeSoB.Text = "Nhập hệ số b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(150, 102);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(150, 20);
            this.txtB.TabIndex = 4;
            // 
            // lblHeSoC
            // 
            this.lblHeSoC.AutoSize = true;
            this.lblHeSoC.Location = new System.Drawing.Point(30, 140);
            this.lblHeSoC.Name = "lblHeSoC";
            this.lblHeSoC.Size = new System.Drawing.Size(74, 13);
            this.lblHeSoC.TabIndex = 5;
            this.lblHeSoC.Text = "Nhập hệ số c:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(150, 137);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(150, 20);
            this.txtC.TabIndex = 6;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(330, 67);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(100, 32);
            this.btnGiai.TabIndex = 7;
            this.btnGiai.Text = "Giải";
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(330, 110);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblNghiemTieuDe
            // 
            this.lblNghiemTieuDe.AutoSize = true;
            this.lblNghiemTieuDe.Location = new System.Drawing.Point(30, 190);
            this.lblNghiemTieuDe.Name = "lblNghiemTieuDe";
            this.lblNghiemTieuDe.Size = new System.Drawing.Size(108, 13);
            this.lblNghiemTieuDe.TabIndex = 9;
            this.lblNghiemTieuDe.Text = "Nghiệm phương trình:";
            // 
            // lblNghiem
            // 
            this.lblNghiem.Location = new System.Drawing.Point(30, 220);
            this.lblNghiem.Name = "lblNghiem";
            this.lblNghiem.Size = new System.Drawing.Size(400, 25);
            this.lblNghiem.TabIndex = 10;
            this.lblNghiem.Text = "------";
            this.lblNghiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 270);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblHeSoA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblHeSoB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblHeSoC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblNghiemTieuDe);
            this.Controls.Add(this.lblNghiem);
            this.Name = "BT3";
            this.Text = "Bài tập";
            this.Load += new System.EventHandler(this.BT3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblHeSoA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblHeSoB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblHeSoC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblNghiemTieuDe;
        private System.Windows.Forms.Label lblNghiem;
    }
}