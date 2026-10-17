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

namespace LapTrinhWindowsForm.Chuong5.ViDu
{
    public partial class VD3 : Form
    {
        int chon = 3;
        DateTime dt = new DateTime();
        public VD3()
        {
            InitializeComponent();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;

            if (chon == 0)
            {
                lblNoiDung.Text = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            }
        }

        private void menuDisplayTime_Click(object sender, EventArgs e)
        {
            chon = 0;
        }

        private void menuDisplayDate_Click(object sender, EventArgs e)
        {
            chon = 1;
            lblNoiDung.Text = dt.Date.ToLongDateString();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }
    }
}
