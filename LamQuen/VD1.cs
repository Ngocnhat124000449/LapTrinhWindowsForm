using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapTrinhWindowsForm.Constraints;
using LapTrinhWindowsForm.utilities;


namespace LapTrinhWindowsForm.LamQuen
{
    public partial class VD1 : Form
    {
        public VD1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double? chieuDai = BusinessConstraints.NhapSoThucDuong(txtCD.Text.Trim(), "Chiều Dài");
            // BusinessConstraints.SoThucDuong: kiểm tra chưa nhập / không phải số / số ≤ 0, tự xuất MessageBox tương ứng
            if (chieuDai == null)
                return;
            // dừng ngay khi sai, MessageBox đã hiện trong hàm ràng buộc

            double? chieuRong = BusinessConstraints.NhapSoThucDuong(txtCR.Text.Trim(), "Chiều rộng");
            if (chieuRong == null)
                return;

            double cv = (chieuDai.Value + chieuRong.Value) * 2;
            // cv: chu vi = (dài + rộng) × 2

            double dt = chieuDai.Value * chieuRong.Value;
            // dt: diện tích = dài × rộng

            txtCV.Text = cv.ToString();
            txtDT.Text = dt.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }
    }
}
