using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong5.ViDu
{
    public partial class VD2 : Form
    {
        int chon = 3;
        DateTime dt = new DateTime();
        public VD2()
        {
            InitializeComponent();
        }

        private void itmThoat_Click(object sender, EventArgs e)
        {

        }

        private void MyTime_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;

            if (chon == 0)
            {
                lblHienThi.Text = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            }
        }

        private void cboChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            chon = cboChucNang.SelectedIndex;
            dt = DateTime.Now;

            if (chon == 1)
            {
                lblHienThi.Text = dt.Date.ToLongDateString();
            }
        }
    }
}
