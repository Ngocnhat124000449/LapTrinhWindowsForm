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

namespace LapTrinhWindowsForm.Chuong5.BaiTap
{
    public partial class BT2_Bai02 : Form
    {
        public BT2_Bai02()
        {
            InitializeComponent();
        }

        private void btnSoThich_Click(object sender, EventArgs e)
        {
            string noiDung = "Các sở thích bạn đã chọn:\n";

            if (chkNgheNhac.Checked)
                noiDung += "- Nghe nhạc\n";
            if (chkXemPhim.Checked)
                noiDung += "- Xem phim\n";
            if (chkTheThao.Checked)
                noiDung += "- Chơi thể thao\n";
            if (chkMuaSam.Checked)
                noiDung += "- Đi mua sắm\n";
            if (chkDuLich.Checked)
                noiDung += "- Đi du lịch\n";

            MyExtentions.ThongBao(this, noiDung, "Pro_Buoi09");
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            string mauDaChon = "";

            if (radDo.Checked)
                mauDaChon = "Đỏ";
            if (radTrang.Checked)
                mauDaChon = "Trắng";
            if (radVang.Checked)
                mauDaChon = "Vàng";
            if (radHong.Checked)
                mauDaChon = "Hồng";
            if (radTim.Checked)
                mauDaChon = "Tím";

            if (mauDaChon == "")
            {
                MyExtentions.ThongBao(this, "Chưa chọn màu bạn thích", "Pro_Buoi09");
                return;
            }

            MyExtentions.ThongBao(this, "Màu bạn thích: " + mauDaChon, "Pro_Buoi09");
        }
    }
}
