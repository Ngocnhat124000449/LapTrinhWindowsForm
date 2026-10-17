namespace LapTrinhWindowsForm.Chuong5.ViDu
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
            this.components = new System.ComponentModel.Container();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.MyTime = new System.Windows.Forms.Timer(this.components);
            this.MyMenu = new System.Windows.Forms.MenuStrip();
            this.itmChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.itmThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.cboChucNang = new System.Windows.Forms.ToolStripComboBox();
            this.MyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThi.Location = new System.Drawing.Point(0, 120);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(448, 50);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.Text = "………..";
            this.lblHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyTime
            // 
            this.MyTime.Enabled = true;
            this.MyTime.Interval = 1000;
            this.MyTime.Tick += new System.EventHandler(this.MyTime_Tick);
            // 
            // MyMenu
            // 
            this.MyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmChucNang,
            this.cboChucNang});
            this.MyMenu.Location = new System.Drawing.Point(0, 0);
            this.MyMenu.Name = "MyMenu";
            this.MyMenu.Size = new System.Drawing.Size(460, 31);
            this.MyMenu.TabIndex = 1;
            // 
            // itmChucNang
            // 
            this.itmChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmThoat});
            this.itmChucNang.Name = "itmChucNang";
            this.itmChucNang.Size = new System.Drawing.Size(87, 27);
            this.itmChucNang.Text = "Chức năng";
            // 
            // itmThoat
            // 
            this.itmThoat.Name = "itmThoat";
            this.itmThoat.ShortcutKeyDisplayString = "Ctrl+T";
            this.itmThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.itmThoat.Size = new System.Drawing.Size(180, 24);
            this.itmThoat.Text = "Thoát";
            this.itmThoat.Click += new System.EventHandler(this.itmThoat_Click);
            // 
            // cboChucNang
            // 
            this.cboChucNang.Items.AddRange(new object[] {
            "Hiển thị thời gian",
            "Hiển thị ngày tháng"});
            this.cboChucNang.Name = "cboChucNang";
            this.cboChucNang.Size = new System.Drawing.Size(121, 27);
            this.cboChucNang.Text = "Nội dung hiển thị";
            this.cboChucNang.SelectedIndexChanged += new System.EventHandler(this.cboChucNang_SelectedIndexChanged);
            // 
            // VD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.MyMenu);
            this.MainMenuStrip = this.MyMenu;
            this.Name = "VD2";
            this.Text = "MenuStrip";
            this.MyMenu.ResumeLayout(false);
            this.MyMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Timer MyTime;
        private System.Windows.Forms.MenuStrip MyMenu;
        private System.Windows.Forms.ToolStripMenuItem itmChucNang;
        private System.Windows.Forms.ToolStripMenuItem itmThoat;
        private System.Windows.Forms.ToolStripComboBox cboChucNang;
    }
}