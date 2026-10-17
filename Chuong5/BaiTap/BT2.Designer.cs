namespace LapTrinhWindowsForm.Chuong5.BaiTap
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai01 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai02 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai03 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai04 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuWindow});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MdiWindowListItem = this.mnuWindow;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(600, 27);
            this.mnuMain.TabIndex = 1;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBai01,
            this.mnuBai02,
            this.mnuBai03,
            this.mnuBai04,
            this.mnuThoat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(41, 23);
            this.mnuFile.Text = "File";
            // 
            // mnuBai01
            // 
            this.mnuBai01.Name = "mnuBai01";
            this.mnuBai01.Size = new System.Drawing.Size(180, 24);
            this.mnuBai01.Text = "Bài 01";
            this.mnuBai01.Click += new System.EventHandler(this.mnuBai01_Click);
            // 
            // mnuBai02
            // 
            this.mnuBai02.Name = "mnuBai02";
            this.mnuBai02.Size = new System.Drawing.Size(180, 24);
            this.mnuBai02.Text = "Bài 02";
            this.mnuBai02.Click += new System.EventHandler(this.mnuBai02_Click);
            // 
            // mnuBai03
            // 
            this.mnuBai03.Name = "mnuBai03";
            this.mnuBai03.Size = new System.Drawing.Size(180, 24);
            this.mnuBai03.Text = "Bài 03";
            this.mnuBai03.Click += new System.EventHandler(this.mnuBai03_Click);
            // 
            // mnuBai04
            // 
            this.mnuBai04.Name = "mnuBai04";
            this.mnuBai04.Size = new System.Drawing.Size(180, 24);
            this.mnuBai04.Text = "Bài 04";
            this.mnuBai04.Click += new System.EventHandler(this.mnuBai04_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(71, 23);
            this.mnuWindow.Text = "Window";
            // 
            // BT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "BT2";
            this.Text = "Tổng Hợp";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuBai01;
        private System.Windows.Forms.ToolStripMenuItem mnuBai02;
        private System.Windows.Forms.ToolStripMenuItem mnuBai03;
        private System.Windows.Forms.ToolStripMenuItem mnuBai04;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}