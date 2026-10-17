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
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void btnDemSoTu_Click(object sender, EventArgs e)
        {
            string chuoiNhap = BusinessConstraints.ChuoiKhongRong(txtChuoi.Text, lblNhapChuoi.Text);
            if (chuoiNhap == null) return;

            List<string> ketQua = BusinessConstraints.ThongKeTanSuatTu(chuoiNhap);
            lstKetQua.Items.Clear();
            lstKetQua.Items.AddRange(ketQua.ToArray());
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtChuoi.Clear();
            lstKetQua.Items.Clear();
        }
    }
}
