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

namespace LapTrinhWindowsForm.Chuong5.ViDu
{
    public partial class VD4 : Form
    {
        public VD4()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }

        private void MyNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("Khoa Công nghệ thông tin, Trường Đại học Lạc Hồng\nXin chào các bạn");
        }
    }
}
