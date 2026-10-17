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

namespace LapTrinhWindowsForm.Chuong4.BaiTap
{
    public partial class BT5 : Form
    {
        public BT5()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("H:m:s");
        }

        private void BT5_Load(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("H:m:s");
        }
    }
}
