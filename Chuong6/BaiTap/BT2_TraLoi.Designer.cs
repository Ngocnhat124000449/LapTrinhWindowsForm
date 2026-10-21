namespace LapTrinhWindowsForm.Chuong6.BaiTap
{
    partial class BT2_TraLoi
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
            this.grpCauHoi = new System.Windows.Forms.GroupBox();
            this.lblNoiDungCauHoi = new System.Windows.Forms.Label();
            this.grpChonDapAn = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTraLoi = new System.Windows.Forms.Button();
            this.grpCauHoi.SuspendLayout();
            this.grpChonDapAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(460, 35);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Câu hỏi trắc nghiệm";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCauHoi
            // 
            this.grpCauHoi.BackColor = System.Drawing.Color.LightCyan;
            this.grpCauHoi.Controls.Add(this.lblNoiDungCauHoi);
            this.grpCauHoi.Location = new System.Drawing.Point(20, 60);
            this.grpCauHoi.Name = "grpCauHoi";
            this.grpCauHoi.Size = new System.Drawing.Size(420, 90);
            this.grpCauHoi.TabIndex = 1;
            this.grpCauHoi.TabStop = false;
            this.grpCauHoi.Text = "Câu hỏi";
            // 
            // lblNoiDungCauHoi
            // 
            this.lblNoiDungCauHoi.Location = new System.Drawing.Point(15, 25);
            this.lblNoiDungCauHoi.Name = "lblNoiDungCauHoi";
            this.lblNoiDungCauHoi.Size = new System.Drawing.Size(390, 55);
            this.lblNoiDungCauHoi.TabIndex = 0;
            // 
            // grpChonDapAn
            // 
            this.grpChonDapAn.BackColor = System.Drawing.Color.LightCyan;
            this.grpChonDapAn.Controls.Add(this.flowLayoutPanel1);
            this.grpChonDapAn.Location = new System.Drawing.Point(20, 160);
            this.grpChonDapAn.Name = "grpChonDapAn";
            this.grpChonDapAn.Size = new System.Drawing.Size(420, 180);
            this.grpChonDapAn.TabIndex = 2;
            this.grpChonDapAn.TabStop = false;
            this.grpChonDapAn.Text = "Chọn đáp án đúng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(390, 140);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnTraLoi
            // 
            this.btnTraLoi.Location = new System.Drawing.Point(300, 355);
            this.btnTraLoi.Name = "btnTraLoi";
            this.btnTraLoi.Size = new System.Drawing.Size(140, 32);
            this.btnTraLoi.TabIndex = 3;
            this.btnTraLoi.Text = "Trả lời";
            this.btnTraLoi.Click += new System.EventHandler(this.btnTraLoi_Click);
            // 
            // BT2_TraLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 410);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpCauHoi);
            this.Controls.Add(this.grpChonDapAn);
            this.Controls.Add(this.btnTraLoi);
            this.Name = "BT2_TraLoi";
            this.Text = "Trắc nghiệm";
            this.grpCauHoi.ResumeLayout(false);
            this.grpChonDapAn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpCauHoi;
        private System.Windows.Forms.Label lblNoiDungCauHoi;
        private System.Windows.Forms.GroupBox grpChonDapAn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTraLoi;
    }
}