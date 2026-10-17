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
    public partial class VD5 : Form
    {
        public VD5()
        {
            InitializeComponent();
        }
        private void CapNhatThongTin()
        {
            txtNam.Text = DTP1.Value.Year.ToString();
            txtNgay.Text = DTP1.Value.Day.ToString();
            txtThang.Text = DTP1.Value.Month.ToString();
            txtGiaTri.Text = DTP1.Value.ToString();
            txtThu.Text = DTP1.Value.DayOfWeek.ToString();
            txtNgayThangNam.Text = DTP1.Value.Date.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }

        private void DTP1_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThongTin();
        }

        private void VD5_Load(object sender, EventArgs e)
        {
            CapNhatThongTin();
        }
    }
}
