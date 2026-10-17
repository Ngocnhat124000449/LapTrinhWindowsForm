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
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }

        private void mnuDate_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = DateTime.Now.ToLongDateString();

        }

        private void mnuTime_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = DateTime.Now.ToLongTimeString();

        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
                // ShowDialog() trả về DialogResult.OK khi người dùng bấm OK trên hộp thoại chọn Font,
                // Cancel thì không làm gì — giữ nguyên Font hiện tại
                txtNoiDung.Font = dlgFont.Font;
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
                txtNoiDung.ForeColor = dlgColor.Color;
        }

        private void mnuAlignLeft_Click(object sender, EventArgs e)
        {
            txtNoiDung.TextAlign = HorizontalAlignment.Left;

        }

        private void mnuAlignRight_Click(object sender, EventArgs e)
        {
            txtNoiDung.TextAlign = HorizontalAlignment.Right;

        }

        private void mnuAlignCenter_Click(object sender, EventArgs e)
        {
            txtNoiDung.TextAlign = HorizontalAlignment.Center;

        }
    }
}
