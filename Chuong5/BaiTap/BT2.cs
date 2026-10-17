using LapTrinhWindowsForm.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong5.BaiTap
{
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void mnuBai01_Click(object sender, EventArgs e)
        {
            BT2_Bai01 frm = new BT2_Bai01();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBai02_Click(object sender, EventArgs e)
        {
            BT2_Bai02 frm = new BT2_Bai02();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBai03_Click(object sender, EventArgs e)
        {
            BT2_Bai03 frm = new BT2_Bai03();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBai04_Click(object sender, EventArgs e)
        {
            BT2_Bai04 frm = new BT2_Bai04();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }
    }
}
