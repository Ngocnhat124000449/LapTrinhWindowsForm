namespace LapTrinhWindowsForm.Chuong4.BaiTap
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
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tmrDongHo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(460, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đồng hồ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDongHo
            // 
            this.lblDongHo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDongHo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDongHo.Location = new System.Drawing.Point(0, 40);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(460, 180);
            this.lblDongHo.TabIndex = 1;
            this.lblDongHo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(180, 240);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tmrDongHo
            // 
            this.tmrDongHo.Enabled = true;
            this.tmrDongHo.Interval = 1000;
            this.tmrDongHo.Tick += new System.EventHandler(this.tmrDongHo_Tick);
            // 
            // BT5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 300);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblDongHo);
            this.Controls.Add(this.btnThoat);
            this.Name = "BT5";
            this.Text = "Bài tập";
            this.Load += new System.EventHandler(this.BT5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}