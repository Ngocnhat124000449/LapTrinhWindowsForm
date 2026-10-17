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
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void BT1_Load(object sender, EventArgs e)
        {

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtChuoi.Text = "";
            txtSoTu.Text = "";
        }

        private void btnDemSoTu_Click(object sender, EventArgs e)
        {
            string chuoiNhap = BusinessConstraints.ChuoiKhongRong(txtChuoi.Text, lblNhapChuoi.Text);
            if (chuoiNhap == null) return;
            int soTu = BusinessConstraints.DemSoTu(txtChuoi.Text);
            txtSoTu.Text = soTu.ToString();
        }
    }
}
