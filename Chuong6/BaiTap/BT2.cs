using LapTrinhWindowsForm.Constraints;
using LapTrinhWindowsForm.utilities;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong6.BaiTap
{
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string noiDungDapAn = BusinessConstraints.ChuoiKhongRong(txtDapAn.Text, lblNoiDungDapAn.Text);
            if (noiDungDapAn == null) return;
            ListViewItem liv = new ListViewItem(noiDungDapAn);
            liv.SubItems.Add(chkDapAnDung.Checked ? "1" : "0");
            lvDapAn.Items.Add(liv);

            txtDapAn.Text = "";
            chkDapAnDung.Checked = false;
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            string cauHoi = BusinessConstraints.ChuoiKhongRong(txtCauHoi.Text, grpCauHoi.Text);
            if (cauHoi == null) return;
            if (lvDapAn.Items.Count == 0)
            {
                MyExtentions.ThongBao(this, "Phải có ít nhất một đáp án");
                return;
            }

            List<string> dsDapAn = new List<string>();
            int viTriDapAnDung = -1;
            for (int i = 0; i < lvDapAn.Items.Count; i++)
            {
                dsDapAn.Add(lvDapAn.Items[i].Text);
                if (lvDapAn.Items[i].SubItems[1].Text == "1") viTriDapAnDung = i;
            }
            if (viTriDapAnDung == -1)
            {
                MyExtentions.ThongBao(this, "Phải có ít nhất một đáp án đùng");
                return;
            }
            BT2_TraLoi frm = new BT2_TraLoi(cauHoi, dsDapAn, viTriDapAnDung);
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }
    }
}
