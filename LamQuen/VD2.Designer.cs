namespace LapTrinhWindowsForm.LamQuen
{
    partial class VD2
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
            this.lblSo1 = new System.Windows.Forms.Label();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.lblSo3 = new System.Windows.Forms.Label();
            this.lblSoLonNhat = new System.Windows.Forms.Label();
            this.TxtSo1 = new System.Windows.Forms.TextBox();
            this.TxtSo2 = new System.Windows.Forms.TextBox();
            this.TxtSo3 = new System.Windows.Forms.TextBox();
            this.TxtKQ = new System.Windows.Forms.TextBox();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSo1.ForeColor = System.Drawing.Color.Navy;
            this.lblSo1.Location = new System.Drawing.Point(30, 40);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(72, 15);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "Số thứ nhất";
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSo2.ForeColor = System.Drawing.Color.Navy;
            this.lblSo2.Location = new System.Drawing.Point(30, 90);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(63, 15);
            this.lblSo2.TabIndex = 1;
            this.lblSo2.Text = "Số thứ hai";
            // 
            // lblSo3
            // 
            this.lblSo3.AutoSize = true;
            this.lblSo3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSo3.ForeColor = System.Drawing.Color.Navy;
            this.lblSo3.Location = new System.Drawing.Point(30, 140);
            this.lblSo3.Name = "lblSo3";
            this.lblSo3.Size = new System.Drawing.Size(60, 15);
            this.lblSo3.TabIndex = 2;
            this.lblSo3.Text = "Số thứ ba";
            // 
            // lblSoLonNhat
            // 
            this.lblSoLonNhat.AutoSize = true;
            this.lblSoLonNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoLonNhat.ForeColor = System.Drawing.Color.Navy;
            this.lblSoLonNhat.Location = new System.Drawing.Point(30, 190);
            this.lblSoLonNhat.Name = "lblSoLonNhat";
            this.lblSoLonNhat.Size = new System.Drawing.Size(70, 15);
            this.lblSoLonNhat.TabIndex = 3;
            this.lblSoLonNhat.Text = "Số lớn nhất";
            // 
            // TxtSo1
            // 
            this.TxtSo1.Location = new System.Drawing.Point(140, 37);
            this.TxtSo1.Name = "TxtSo1";
            this.TxtSo1.Size = new System.Drawing.Size(150, 20);
            this.TxtSo1.TabIndex = 4;
            // 
            // TxtSo2
            // 
            this.TxtSo2.Location = new System.Drawing.Point(140, 87);
            this.TxtSo2.Name = "TxtSo2";
            this.TxtSo2.Size = new System.Drawing.Size(150, 20);
            this.TxtSo2.TabIndex = 5;
            // 
            // TxtSo3
            // 
            this.TxtSo3.Location = new System.Drawing.Point(140, 137);
            this.TxtSo3.Name = "TxtSo3";
            this.TxtSo3.Size = new System.Drawing.Size(150, 20);
            this.TxtSo3.TabIndex = 6;
            // 
            // TxtKQ
            // 
            this.TxtKQ.Location = new System.Drawing.Point(140, 187);
            this.TxtKQ.Name = "TxtKQ";
            this.TxtKQ.ReadOnly = true;
            this.TxtKQ.Size = new System.Drawing.Size(150, 20);
            this.TxtKQ.TabIndex = 7;
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Tinh.ForeColor = System.Drawing.Color.Red;
            this.btn_Tinh.Location = new System.Drawing.Point(330, 87);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(100, 35);
            this.btn_Tinh.TabIndex = 8;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_Thoat.Location = new System.Drawing.Point(330, 137);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 35);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // VD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.lblSo1);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.lblSo3);
            this.Controls.Add(this.lblSoLonNhat);
            this.Controls.Add(this.TxtSo1);
            this.Controls.Add(this.TxtSo2);
            this.Controls.Add(this.TxtSo3);
            this.Controls.Add(this.TxtKQ);
            this.Controls.Add(this.btn_Tinh);
            this.Controls.Add(this.btn_Thoat);
            this.Name = "VD2";
            this.Text = "Số lớn nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.Label lblSo3;
        private System.Windows.Forms.Label lblSoLonNhat;
        private System.Windows.Forms.TextBox TxtSo1;
        private System.Windows.Forms.TextBox TxtSo2;
        private System.Windows.Forms.TextBox TxtSo3;
        private System.Windows.Forms.TextBox TxtKQ;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Button btn_Thoat;
    }
}