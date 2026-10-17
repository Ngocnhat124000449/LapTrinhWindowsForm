namespace LapTrinhWindowsForm.Chuong5.ViDu
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
            this.components = new System.ComponentModel.Container();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.MyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDisplayTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayDate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNoiDung.Location = new System.Drawing.Point(150, 120);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(154, 24);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.Text = "-----Nội dung------";
            // 
            // MyTimer
            // 
            this.MyTimer.Enabled = true;
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // MyContextMenu
            // 
            this.MyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDisplayTime,
            this.menuDisplayDate,
            this.menuExit});
            this.MyContextMenu.Name = "MyContextMenu";
            this.MyContextMenu.Size = new System.Drawing.Size(201, 98);
            // 
            // menuDisplayTime
            // 
            this.menuDisplayTime.Name = "menuDisplayTime";
            this.menuDisplayTime.Size = new System.Drawing.Size(200, 24);
            this.menuDisplayTime.Text = "Hiển thị thời gian";
            this.menuDisplayTime.Click += new System.EventHandler(this.menuDisplayTime_Click);
            // 
            // menuDisplayDate
            // 
            this.menuDisplayDate.Name = "menuDisplayDate";
            this.menuDisplayDate.Size = new System.Drawing.Size(200, 24);
            this.menuDisplayDate.Text = "Hiển thị ngày tháng";
            this.menuDisplayDate.Click += new System.EventHandler(this.menuDisplayDate_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeyDisplayString = "Ctrl+T";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuExit.Size = new System.Drawing.Size(200, 24);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // VD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.ContextMenuStrip = this.MyContextMenu;
            this.Controls.Add(this.lblNoiDung);
            this.Name = "VD3";
            this.Text = "ContextMenuStrip";
            this.MyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.ContextMenuStrip MyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayTime;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayDate;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}