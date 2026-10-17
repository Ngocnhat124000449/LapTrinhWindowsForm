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
using LapTrinhWindowsForm.utilities;

namespace LapTrinhWindowsForm.Chuong3.BaiTap
{
    public partial class BT4 : Form
    {
        public BT4()
        {
            InitializeComponent();
        }

        private void BT4_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var chuoiNhap = BusinessConstraints.ChuoiKhongRong(txtDaySo.Text, lblNhapDaySo.Text);
            if (chuoiNhap== null) return;

            List<int> daySo = BusinessConstraints.TachDayThanhSoNguyen(chuoiNhap);

            var soChinhPhuong = new List<int>();

            foreach (int ChinhPhuong in daySo)
                if (BusinessConstraints.TimSoChinhPhuong(ChinhPhuong)) soChinhPhuong.Add(ChinhPhuong);

            lblKetQua.Text = string.Join(", ", soChinhPhuong);


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }
    }
}
