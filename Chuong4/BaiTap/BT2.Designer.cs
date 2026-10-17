namespace LapTrinhWindowsForm.Chuong4.BaiTap
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
            this.lblNhapChuoi = new System.Windows.Forms.Label();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.lblKetQuaThongKe = new System.Windows.Forms.Label();
            this.lvThongKe = new System.Windows.Forms.ListView();
            this.colTuDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTanSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChuanHoa = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapChuoi
            // 
            this.lblNhapChuoi.AutoSize = true;
            this.lblNhapChuoi.Location = new System.Drawing.Point(30, 20);
            this.lblNhapChuoi.Name = "lblNhapChuoi";
            this.lblNhapChuoi.Size = new System.Drawing.Size(65, 13);
            this.lblNhapChuoi.TabIndex = 0;
            this.lblNhapChuoi.Text = "Nhập chuỗi:";
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(30, 45);
            this.txtChuoi.Multiline = true;
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(280, 220);
            this.txtChuoi.TabIndex = 1;
            // 
            // lblKetQuaThongKe
            // 
            this.lblKetQuaThongKe.AutoSize = true;
            this.lblKetQuaThongKe.Location = new System.Drawing.Point(330, 20);
            this.lblKetQuaThongKe.Name = "lblKetQuaThongKe";
            this.lblKetQuaThongKe.Size = new System.Drawing.Size(89, 13);
            this.lblKetQuaThongKe.TabIndex = 2;
            this.lblKetQuaThongKe.Text = "Kết quả thống kê";
            // 
            // lvThongKe
            // 
            this.lvThongKe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTuDon,
            this.colTanSo});
            this.lvThongKe.FullRowSelect = true;
            this.lvThongKe.GridLines = true;
            this.lvThongKe.HideSelection = false;
            this.lvThongKe.Location = new System.Drawing.Point(330, 45);
            this.lvThongKe.Name = "lvThongKe";
            this.lvThongKe.Size = new System.Drawing.Size(220, 220);
            this.lvThongKe.TabIndex = 3;
            this.lvThongKe.UseCompatibleStateImageBehavior = false;
            this.lvThongKe.View = System.Windows.Forms.View.Details;
            // 
            // colTuDon
            // 
            this.colTuDon.Text = "Từ Đơn";
            this.colTuDon.Width = 120;
            // 
            // colTanSo
            // 
            this.colTanSo.Text = "Tần Số";
            this.colTanSo.Width = 90;
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.Location = new System.Drawing.Point(30, 280);
            this.btnChuanHoa.Name = "btnChuanHoa";
            this.btnChuanHoa.Size = new System.Drawing.Size(100, 32);
            this.btnChuanHoa.TabIndex = 4;
            this.btnChuanHoa.Text = "Chuẩn Hóa";
            this.btnChuanHoa.Click += new System.EventHandler(this.btnChuanHoa_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(330, 280);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 32);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(450, 280);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 32);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // BT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 340);
            this.Controls.Add(this.lblNhapChuoi);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.lblKetQuaThongKe);
            this.Controls.Add(this.lvThongKe);
            this.Controls.Add(this.btnChuanHoa);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnLuu);
            this.Name = "BT2";
            this.Text = "Bài 03";
            this.Load += new System.EventHandler(this.BT2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapChuoi;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Label lblKetQuaThongKe;
        private System.Windows.Forms.ListView lvThongKe;
        private System.Windows.Forms.ColumnHeader colTuDon;
        private System.Windows.Forms.ColumnHeader colTanSo;
        private System.Windows.Forms.Button btnChuanHoa;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLuu;
    }
}