namespace LapTrinhWindowsForm.Chuong6.ViDu
{
    partial class VD1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapChuoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDen = new System.Windows.Forms.RadioButton();
            this.radDo = new System.Windows.Forms.RadioButton();
            this.radXanh = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGachChan = new System.Windows.Forms.RadioButton();
            this.radInNghieng = new System.Windows.Forms.RadioButton();
            this.radInDam = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblChuoiDinhDang = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(210, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỊNH DẠNG CHUỖI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập chuỗi muốn định dạng:";
            // 
            // txtNhapChuoi
            // 
            this.txtNhapChuoi.Location = new System.Drawing.Point(210, 73);
            this.txtNhapChuoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhapChuoi.Name = "txtNhapChuoi";
            this.txtNhapChuoi.Size = new System.Drawing.Size(324, 20);
            this.txtNhapChuoi.TabIndex = 2;
            this.txtNhapChuoi.TextChanged += new System.EventHandler(this.txtNhapChuoi_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDen);
            this.groupBox1.Controls.Add(this.radDo);
            this.groupBox1.Controls.Add(this.radXanh);
            this.groupBox1.Location = new System.Drawing.Point(30, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(218, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu";
            // 
            // radDen
            // 
            this.radDen.AutoSize = true;
            this.radDen.Location = new System.Drawing.Point(22, 73);
            this.radDen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radDen.Name = "radDen";
            this.radDen.Size = new System.Drawing.Size(45, 17);
            this.radDen.TabIndex = 2;
            this.radDen.TabStop = true;
            this.radDen.Text = "Đen";
            this.radDen.UseVisualStyleBackColor = true;
            this.radDen.CheckedChanged += new System.EventHandler(this.radDen_CheckedChanged);
            // 
            // radDo
            // 
            this.radDo.AutoSize = true;
            this.radDo.Location = new System.Drawing.Point(22, 46);
            this.radDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radDo.Name = "radDo";
            this.radDo.Size = new System.Drawing.Size(39, 17);
            this.radDo.TabIndex = 1;
            this.radDo.TabStop = true;
            this.radDo.Text = "Đỏ";
            this.radDo.UseVisualStyleBackColor = true;
            this.radDo.CheckedChanged += new System.EventHandler(this.radDo_CheckedChanged);
            // 
            // radXanh
            // 
            this.radXanh.AutoSize = true;
            this.radXanh.Location = new System.Drawing.Point(22, 19);
            this.radXanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radXanh.Name = "radXanh";
            this.radXanh.Size = new System.Drawing.Size(50, 17);
            this.radXanh.TabIndex = 0;
            this.radXanh.TabStop = true;
            this.radXanh.Text = "Xanh";
            this.radXanh.UseVisualStyleBackColor = true;
            this.radXanh.CheckedChanged += new System.EventHandler(this.radXanh_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radGachChan);
            this.groupBox2.Controls.Add(this.radInNghieng);
            this.groupBox2.Controls.Add(this.radInDam);
            this.groupBox2.Location = new System.Drawing.Point(30, 229);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(218, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểu hiển thị";
            // 
            // radGachChan
            // 
            this.radGachChan.AutoSize = true;
            this.radGachChan.Location = new System.Drawing.Point(22, 73);
            this.radGachChan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGachChan.Name = "radGachChan";
            this.radGachChan.Size = new System.Drawing.Size(78, 17);
            this.radGachChan.TabIndex = 2;
            this.radGachChan.TabStop = true;
            this.radGachChan.Text = "Gạch chân";
            this.radGachChan.UseVisualStyleBackColor = true;
            this.radGachChan.CheckedChanged += new System.EventHandler(this.radGachChan_CheckedChanged);
            // 
            // radInNghieng
            // 
            this.radInNghieng.AutoSize = true;
            this.radInNghieng.Location = new System.Drawing.Point(22, 46);
            this.radInNghieng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radInNghieng.Name = "radInNghieng";
            this.radInNghieng.Size = new System.Drawing.Size(77, 17);
            this.radInNghieng.TabIndex = 1;
            this.radInNghieng.TabStop = true;
            this.radInNghieng.Text = "In Nghiêng";
            this.radInNghieng.UseVisualStyleBackColor = true;
            this.radInNghieng.CheckedChanged += new System.EventHandler(this.radInNghieng_CheckedChanged);
            // 
            // radInDam
            // 
            this.radInDam.AutoSize = true;
            this.radInDam.Location = new System.Drawing.Point(22, 19);
            this.radInDam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radInDam.Name = "radInDam";
            this.radInDam.Size = new System.Drawing.Size(58, 17);
            this.radInDam.TabIndex = 0;
            this.radInDam.TabStop = true;
            this.radInDam.Text = "In đậm";
            this.radInDam.UseVisualStyleBackColor = true;
            this.radInDam.CheckedChanged += new System.EventHandler(this.radInDam_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblChuoiDinhDang);
            this.groupBox3.Location = new System.Drawing.Point(262, 115);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(285, 222);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuỗi sau khi định dạng";
            // 
            // lblChuoiDinhDang
            // 
            this.lblChuoiDinhDang.AutoSize = true;
            this.lblChuoiDinhDang.Location = new System.Drawing.Point(15, 27);
            this.lblChuoiDinhDang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChuoiDinhDang.Name = "lblChuoiDinhDang";
            this.lblChuoiDinhDang.Size = new System.Drawing.Size(85, 13);
            this.lblChuoiDinhDang.TabIndex = 0;
            this.lblChuoiDinhDang.Text = "Chuỗi định dạng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(488, 352);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 24);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // VD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 398);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhapChuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VD1";
            this.Text = "GroupBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapChuoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDen;
        private System.Windows.Forms.RadioButton radDo;
        private System.Windows.Forms.RadioButton radXanh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radGachChan;
        private System.Windows.Forms.RadioButton radInNghieng;
        private System.Windows.Forms.RadioButton radInDam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblChuoiDinhDang;
        private System.Windows.Forms.Button btnThoat;
    }
}