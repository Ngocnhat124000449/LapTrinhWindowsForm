using LapTrinhWindowsForm.Constraints;
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

namespace LapTrinhWindowsForm.Chuong3.BaiTap
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
        }

        private void BT3_Load(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double? a = BusinessConstraints.HeSoKhacKhong(txtA.Text, lblHeSoA.Text);
            if (a == null) return;

            double? b = BusinessConstraints.SoThuc(txtB.Text, lblHeSoB.Text);
            if (b == null) return;

            double? c = BusinessConstraints.SoThuc(txtC.Text, lblHeSoC.Text);
            if (c == null) return;

            lblNghiem.Text = BusinessConstraints.GiaiPhuongTrinhBacHai(a.Value, b.Value, c.Value);

            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }
    }
}
