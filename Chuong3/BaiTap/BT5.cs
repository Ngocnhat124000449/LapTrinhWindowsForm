using LapTrinhWindowsForm.Constraints;
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
    public partial class BT5 : Form
    {
        public BT5()
        {
            InitializeComponent();
        }

        private void BT5_Load(object sender, EventArgs e)
        {

        }

        private void btnPhanTich_Click(object sender, EventArgs e)
        {
            long? soNhap = BusinessConstraints.SoNguyenToiThieu(txtSo.Text, lblNhapSo.Text,4);
            if (soNhap== null) return;

            lblKetQua.Text = BusinessConstraints.PhanTichThuaSoNguyenTo(soNhap.Value);
        }
    }
}
