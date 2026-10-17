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
    public partial class VD6 : Form
    {
        public VD6()
        {
            InitializeComponent();
        }

        private void VD6_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string str = "";
            str = str + "Họ tên: " + txtHoTen.Text + "\nLớp: " + txtLop.Text + "\nDanh sách môn: ";

            if (chkCSharp.Checked == true)
                str = str + "Lập trình C#, ";
            if (chkMang.Checked == true)
                str = str + "Mạng máy tính, ";
            if (chkWeb.Checked == true)
                str = str + "Lập trình Web, ";
            if (chkXLAnh.Checked == true)
                str = str + "Xử lý ảnh, ";

            MessageBox.Show(str);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }
    }
}
