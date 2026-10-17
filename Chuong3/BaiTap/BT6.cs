using LapTrinhWindowsForm.Constraints;
using LapTrinhWindowsForm.utilities;
using Microsoft.Win32.SafeHandles;
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
    public partial class BT6 : Form
    {
        public BT6()
        {
            InitializeComponent();
        }

        private void btnChuyenMot_Click(object sender, EventArgs e)
        {
            if (!BusinessConstraints.CoPhanTuDuocChon(lstMonAn, lblDanhSachMonAn.Text)) return;

            BusinessConstraints.ChuyenMonDaChon(lstMonAn, lstThucDon);
        }

        private void btnTraMot_Click(object sender, EventArgs e)
        {
            if (!BusinessConstraints.CoPhanTuDuocChon(lstThucDon, lblDanhSachThucDon.Text)) return;

            BusinessConstraints.ChuyenMonDaChon(lstThucDon, lstMonAn);
        }

        private void btnChuyenTatCa_Click(object sender, EventArgs e)
        {
            BusinessConstraints.ChuyenTatCa(lstMonAn, lstThucDon);
        }

        private void btnTraTatCa_Click(object sender, EventArgs e)
        {
            BusinessConstraints.ChuyenTatCa(lstThucDon, lstMonAn);
        }

        private void btnInThucDon_Click(object sender, EventArgs e)
        {
            if (lstThucDon.Items.Count <= 0)
            {
                MessageBox.Show("Danh sách thực đơn đang trống");
                return;
            }
            var danhSachMonTrongThucDon = lstThucDon.Items.Cast<object>().Select(chon=> chon.ToString());
            var noiDungThongBao = string.Join(Environment.NewLine, danhSachMonTrongThucDon);
            MessageBox.Show(noiDungThongBao, "Thực đơn trong ngày");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }
    }
}
