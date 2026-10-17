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

namespace LapTrinhWindowsForm.Chuong4.ViDu
{
    public partial class VD1 : Form
    {
        public VD1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MyExtentions.ThongBao(this, "Bạn đăng đăng nhập thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }

        private void VD1_Load(object sender, EventArgs e)
        {
            ttpDangNhap.SetToolTip(txtDangNhap, "Nhập chuỗi ký tự không dấu, không khoảng trắng");
            ttpMatKhau.SetToolTip(txtMatKhau, "Nhập ít nhất 6 ký tự, nhiều nhất 10 ký tự");
        }
    }
}
