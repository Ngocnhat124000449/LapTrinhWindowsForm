using LapTrinhWindowsForm.Constraints;
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
    public partial class VD3 : Form
    {
        public VD3()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLop = BusinessConstraints.ChuoiKhongRong(txtTenLop.Text, "tên lớp");

            if (tenLop == null)
                return;

            string soLuong = BusinessConstraints.ChuoiKhongRong(txtSoLuong.Text, "số lượng sinh viên");

            if (soLuong == null)
                return;

            ListViewItem LVItem = new ListViewItem(tenLop);
            ListViewItem.ListViewSubItem LVSItem = new ListViewItem.ListViewSubItem(LVItem, soLuong);
            LVItem.SubItems.Add(LVSItem);
            myListView.Items.Add(LVItem);
        }

        private void VD3_Load(object sender, EventArgs e)
        {
            myListView.Columns.Add("Tên Lớp", 160);
            myListView.Columns.Add("Số lượng sinh viên", 140);
        }
    }
}
