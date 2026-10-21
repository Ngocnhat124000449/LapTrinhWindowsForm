namespace LapTrinhWindowsForm.Chuong6.BaiTap
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
            this.lblTongNut = new System.Windows.Forms.Label();
            this.txtTongNut = new System.Windows.Forms.TextBox();
            this.lblNutHang = new System.Windows.Forms.Label();
            this.txtNutHang = new System.Windows.Forms.TextBox();
            this.btnPhatSinh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTongNut
            // 
            this.lblTongNut.AutoSize = true;
            this.lblTongNut.Location = new System.Drawing.Point(20, 20);
            this.lblTongNut.Name = "lblTongNut";
            this.lblTongNut.Size = new System.Drawing.Size(147, 13);
            this.lblTongNut.TabIndex = 0;
            this.lblTongNut.Text = "Nhập số button cần phát sinh";
            // 
            // txtTongNut
            // 
            this.txtTongNut.Location = new System.Drawing.Point(230, 17);
            this.txtTongNut.Name = "txtTongNut";
            this.txtTongNut.Size = new System.Drawing.Size(100, 20);
            this.txtTongNut.TabIndex = 1;
            // 
            // lblNutHang
            // 
            this.lblNutHang.AutoSize = true;
            this.lblNutHang.Location = new System.Drawing.Point(20, 50);
            this.lblNutHang.Name = "lblNutHang";
            this.lblNutHang.Size = new System.Drawing.Size(148, 13);
            this.lblNutHang.TabIndex = 2;
            this.lblNutHang.Text = "Nhập số button trên một hàng";
            // 
            // txtNutHang
            // 
            this.txtNutHang.Location = new System.Drawing.Point(230, 47);
            this.txtNutHang.Name = "txtNutHang";
            this.txtNutHang.Size = new System.Drawing.Size(100, 20);
            this.txtNutHang.TabIndex = 3;
            // 
            // btnPhatSinh
            // 
            this.btnPhatSinh.Location = new System.Drawing.Point(350, 17);
            this.btnPhatSinh.Name = "btnPhatSinh";
            this.btnPhatSinh.Size = new System.Drawing.Size(100, 53);
            this.btnPhatSinh.TabIndex = 4;
            this.btnPhatSinh.Text = "Phát Sinh";
            this.btnPhatSinh.Click += new System.EventHandler(this.btnPhatSinh_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 320);
            this.panel1.TabIndex = 5;
            // 
            // BT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 430);
            this.Controls.Add(this.lblTongNut);
            this.Controls.Add(this.txtTongNut);
            this.Controls.Add(this.lblNutHang);
            this.Controls.Add(this.txtNutHang);
            this.Controls.Add(this.btnPhatSinh);
            this.Controls.Add(this.panel1);
            this.Name = "BT1";
            this.Text = "Bài 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTongNut;
        private System.Windows.Forms.TextBox txtTongNut;
        private System.Windows.Forms.Label lblNutHang;
        private System.Windows.Forms.TextBox txtNutHang;
        private System.Windows.Forms.Button btnPhatSinh;
        private System.Windows.Forms.Panel panel1;
    }
}