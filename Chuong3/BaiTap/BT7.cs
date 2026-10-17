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
    public partial class BT7 : Form
    {
        public BT7()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = BusinessConstraints.ChuoiKhongRong(txtTen.Text, lblTen.Text);
            if (ten == null) return;
            string matKhau = BusinessConstraints.ChuoiKhongRong(txtMatKhau.Text, lblMatKhau.Text);
            if (matKhau == null) return;
            if (ten == "admin" && matKhau == "123456")
                MyExtentions.ThongBao(this, "Đăng nhập thành công");
            else MyExtentions.ThongBao(this, "Đăng nhập không thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
