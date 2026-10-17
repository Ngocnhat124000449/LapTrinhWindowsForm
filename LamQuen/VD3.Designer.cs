namespace LapTrinhWindowsForm.LamQuen
{
    partial class VD3
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
            this.btn_HCN = new System.Windows.Forms.Button();
            this.btn_SoLN = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HCN
            // 
            this.btn_HCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HCN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_HCN.ForeColor = System.Drawing.Color.Blue;
            this.btn_HCN.Location = new System.Drawing.Point(60, 90);
            this.btn_HCN.Name = "btn_HCN";
            this.btn_HCN.Size = new System.Drawing.Size(180, 40);
            this.btn_HCN.TabIndex = 0;
            this.btn_HCN.Text = "Hình chữ nhật";
            this.btn_HCN.Click += new System.EventHandler(this.btn_HCN_Click);
            // 
            // btn_SoLN
            // 
            this.btn_SoLN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SoLN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SoLN.ForeColor = System.Drawing.Color.Blue;
            this.btn_SoLN.Location = new System.Drawing.Point(60, 150);
            this.btn_SoLN.Name = "btn_SoLN";
            this.btn_SoLN.Size = new System.Drawing.Size(180, 40);
            this.btn_SoLN.TabIndex = 1;
            this.btn_SoLN.Text = "Số lớn nhất";
            this.btn_SoLN.Click += new System.EventHandler(this.btn_SoLN_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Thoat.ForeColor = System.Drawing.Color.Blue;
            this.btn_Thoat.Location = new System.Drawing.Point(320, 90);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(180, 40);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // VD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.btn_HCN);
            this.Controls.Add(this.btn_SoLN);
            this.Controls.Add(this.btn_Thoat);
            this.Name = "VD3";
            this.Text = "FrmChinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HCN;
        private System.Windows.Forms.Button btn_SoLN;
        private System.Windows.Forms.Button btn_Thoat;
    }
}