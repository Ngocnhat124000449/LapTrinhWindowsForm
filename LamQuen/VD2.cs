using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapTrinhWindowsForm.Constraints;
using LapTrinhWindowsForm.utilities;

namespace LapTrinhWindowsForm.LamQuen
{
    public partial class VD2 : Form
    {
        public VD2()
        {
            InitializeComponent();
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            double? So1 = BusinessConstraints.SoThuc(TxtSo1.Text, lblSo1.Text);
            if (So1 == null) return;

            double? so2 = BusinessConstraints.SoThuc(TxtSo2.Text, lblSo2.Text);
            if (so2 == null) return;

            double? so3 = BusinessConstraints.SoThuc(TxtSo3.Text, lblSoLonNhat.Text);
            if (so3 == null) return;

            double max = So1.Value;

            if (so2.Value > max) max = so2.Value;
            if (so3.Value > max) max = so3.Value;
            TxtKQ.Text = max.ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }
    }
}
