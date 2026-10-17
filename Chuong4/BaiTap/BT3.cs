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

namespace LapTrinhWindowsForm.Chuong4.BaiTap
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            // Clear(): xóa mọi icon lỗi từ lần bấm trước đó trước khi kiểm tra lại từ đầu

            bool hopLe = true;

            if (!BusinessConstraints.LaNgaySinhHopLe(txtNgaySinh.Text, out DateTime ngaySinh))
            {
                errProvider.SetError(txtNgaySinh, "Ngày sinh dd/mm/yyyy");
                hopLe = false;
            }

            if (!BusinessConstraints.LaDiemHopLe(txtDiemTB.Text, out double diemTB))
            {
                errProvider.SetError(txtDiemTB, "Nhập số");
                hopLe = false;
            }

            if (hopLe)
                MyExtentions.ThongBao(this, "Đăng ký thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MyExtentions.XacNhanThoat(this))
                this.Close();
        }
    }
}
