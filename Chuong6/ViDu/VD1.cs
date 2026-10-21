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

namespace LapTrinhWindowsForm.Chuong6.ViDu
{
    public partial class VD1 : Form
    {
        public VD1()
        {
            InitializeComponent();
        }

        private void txtNhapChuoi_TextChanged(object sender, EventArgs e)
        {
            lblChuoiDinhDang.Text = txtNhapChuoi.Text;
        }

        private void radXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (radXanh.Checked == true)
            {
                lblChuoiDinhDang.ForeColor = Color.Blue;
            }
        }

        private void radDo_CheckedChanged(object sender, EventArgs e)
        {
            if (radDo.Checked == true)
            {
                lblChuoiDinhDang.ForeColor = Color.Red;
            }
        }

        private void radDen_CheckedChanged(object sender, EventArgs e)
        {
            if (radDen.Checked == true)
            {
                lblChuoiDinhDang.ForeColor = Color.Black;
            }
        }

        private void radInDam_CheckedChanged(object sender, EventArgs e)
        {
            lblChuoiDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        }

        private void radInNghieng_CheckedChanged(object sender, EventArgs e)
        {
            if (radInNghieng.Checked == true)
            {
                lblChuoiDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            }
        }
        private void radGachChan_CheckedChanged(object sender, EventArgs e)
        {
            if (radGachChan.Checked == true)
            {
                lblChuoiDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }
    }
}