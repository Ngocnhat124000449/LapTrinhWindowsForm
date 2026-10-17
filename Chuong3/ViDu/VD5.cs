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

namespace LapTrinhWindowsForm.Chuong3.ViDu
{
    public partial class VD5 : Form
    {
        public VD5()
        {
            InitializeComponent();
        }

        private void btnDoiMau_Click(object sender, EventArgs e)
        {
            if (cboChonMau.Text == "Vàng")
                lblHienThi.ForeColor = Color.Yellow;
            if (cboChonMau.Text == "Đỏ")
                lblHienThi.ForeColor = Color.Red;
            if (cboChonMau.Text == "Đen")
                lblHienThi.ForeColor = Color.Black;
            if (cboChonMau.Text == "Xanh")
                lblHienThi.ForeColor = Color.Blue;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }
    }
}
