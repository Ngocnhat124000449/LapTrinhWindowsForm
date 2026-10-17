namespace LapTrinhWindowsForm.Chuong4.ViDu
{
    partial class VD4
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
            this.label1 = new System.Windows.Forms.Label();
            this.TV_Test = new System.Windows.Forms.TreeView();
            this.btnMoRong = new System.Windows.Forms.Button();
            this.btnThuNho = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.btnThemGoc = new System.Windows.Forms.Button();
            this.btnThemCon = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TreeView";
            // 
            // TV_Test
            // 
            this.TV_Test.Location = new System.Drawing.Point(30, 55);
            this.TV_Test.Name = "TV_Test";
            this.TV_Test.Size = new System.Drawing.Size(260, 260);
            this.TV_Test.TabIndex = 1;
            // 
            // btnMoRong
            // 
            this.btnMoRong.Location = new System.Drawing.Point(80, 325);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.Size = new System.Drawing.Size(60, 30);
            this.btnMoRong.TabIndex = 2;
            this.btnMoRong.Text = "+";
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click);
            // 
            // btnThuNho
            // 
            this.btnThuNho.Location = new System.Drawing.Point(150, 325);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(60, 30);
            this.btnThuNho.TabIndex = 3;
            this.btnThuNho.Text = "-";
            this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiêu đề node:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(430, 27);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(180, 20);
            this.txtTieuDe.TabIndex = 5;
            // 
            // btnThemGoc
            // 
            this.btnThemGoc.Location = new System.Drawing.Point(320, 65);
            this.btnThemGoc.Name = "btnThemGoc";
            this.btnThemGoc.Size = new System.Drawing.Size(290, 32);
            this.btnThemGoc.TabIndex = 6;
            this.btnThemGoc.Text = "Thêm node gốc";
            this.btnThemGoc.Click += new System.EventHandler(this.btnThemGoc_Click);
            // 
            // btnThemCon
            // 
            this.btnThemCon.Location = new System.Drawing.Point(320, 105);
            this.btnThemCon.Name = "btnThemCon";
            this.btnThemCon.Size = new System.Drawing.Size(290, 32);
            this.btnThemCon.TabIndex = 7;
            this.btnThemCon.Text = "Thêm node con tại vị trí chọn";
            this.btnThemCon.Click += new System.EventHandler(this.btnThemCon_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(320, 145);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(290, 32);
            this.btnXoaTatCa.TabIndex = 8;
            this.btnXoaTatCa.Text = "Xóa tất cả các node";
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(320, 185);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(290, 32);
            this.btnXoaChon.TabIndex = 9;
            this.btnXoaChon.Text = "Xóa node đang chọn";
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(320, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(290, 32);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // VD4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TV_Test);
            this.Controls.Add(this.btnMoRong);
            this.Controls.Add(this.btnThuNho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.btnThemGoc);
            this.Controls.Add(this.btnThemCon);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.btnThoat);
            this.Name = "VD4";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView TV_Test;
        private System.Windows.Forms.Button btnMoRong;
        private System.Windows.Forms.Button btnThuNho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Button btnThemGoc;
        private System.Windows.Forms.Button btnThemCon;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnThoat;
    }
}