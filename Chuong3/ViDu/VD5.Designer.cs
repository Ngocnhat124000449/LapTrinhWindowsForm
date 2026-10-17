namespace LapTrinhWindowsForm.Chuong3.ViDu
{
    partial class VD5
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
            this.lblChonMau = new System.Windows.Forms.Label();
            this.cboChonMau = new System.Windows.Forms.ComboBox();
            this.btnDoiMau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChonMau
            // 
            this.lblChonMau.AutoSize = true;
            this.lblChonMau.Location = new System.Drawing.Point(30, 35);
            this.lblChonMau.Name = "lblChonMau";
            this.lblChonMau.Size = new System.Drawing.Size(58, 13);
            this.lblChonMau.TabIndex = 0;
            this.lblChonMau.Text = "Chọn màu:";
            // 
            // cboChonMau
            // 
            this.cboChonMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonMau.Items.AddRange(new object[] {
            "Vàng",
            "Xanh",
            "Đỏ",
            "Đen"});
            this.cboChonMau.Location = new System.Drawing.Point(110, 32);
            this.cboChonMau.Name = "cboChonMau";
            this.cboChonMau.Size = new System.Drawing.Size(120, 21);
            this.cboChonMau.TabIndex = 1;
            // 
            // btnDoiMau
            // 
            this.btnDoiMau.Location = new System.Drawing.Point(250, 30);
            this.btnDoiMau.Name = "btnDoiMau";
            this.btnDoiMau.Size = new System.Drawing.Size(100, 28);
            this.btnDoiMau.TabIndex = 2;
            this.btnDoiMau.Text = "Đổi màu";
            this.btnDoiMau.Click += new System.EventHandler(this.btnDoiMau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(370, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHienThi.Location = new System.Drawing.Point(30, 100);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(507, 31);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.Text = "Hoàng Sa, Trường Sa là của Việt Nam";
            // 
            // VD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 180);
            this.Controls.Add(this.lblChonMau);
            this.Controls.Add(this.cboChonMau);
            this.Controls.Add(this.btnDoiMau);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblHienThi);
            this.Name = "VD5";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChonMau;
        private System.Windows.Forms.ComboBox cboChonMau;
        private System.Windows.Forms.Button btnDoiMau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblHienThi;
    }
}