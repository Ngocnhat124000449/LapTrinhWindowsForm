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

namespace LapTrinhWindowsForm.Chuong3.ViDu
{
    public partial class VD7 : Form
    {
        public VD7()
        {
            InitializeComponent();
        }

        private void VD7_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
            string str = "";
            str = "Họ tên: " + txtHoTen.Text + "\r\nKhoa: " + txtKhoa.Text + "\r\n";

            if (radNam.Checked == true)
                str = str + "Giới tính: Nam\r\n";
            if (radNu.Checked == true)
                str = str + "Giới tính: Nu\r\n";

            str = str + "Chuyên ngành: ";

            if (radKTMT.Checked == true)
                str = str + " Kỹ thuật máy tính";
            if (radMMTTT.Checked == true)
                str = str + "Mạng máy tính và truyền thông";
            if (radHTTT.Checked == true)
                str = str + " Hệ thống thông tin";
            if (radCNPM.Checked == true)
                str = str + " Công nghệ phần mềm";

            txtNoiDung.Text = str;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }
    }
}
