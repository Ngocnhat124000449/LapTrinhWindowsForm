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
    public partial class VD3 : Form
    {
        public VD3()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtLuongCBNV.Text != "" && txtHoTenNV.Text != "" &&
                txtHeSoLuongNV.Text != "" && txtChucVuNV.Text != "")
            {
                ListViewItem LVItem = new ListViewItem(txtHoTenNV.Text);
                ListViewItem.ListViewSubItem LVSItemCV = new ListViewItem.ListViewSubItem(LVItem, txtChucVuNV.Text);
                ListViewItem.ListViewSubItem LVSItemHSL = new ListViewItem.ListViewSubItem(LVItem, txtHeSoLuongNV.Text);
                ListViewItem.ListViewSubItem LVSItemLCB = new ListViewItem.ListViewSubItem(LVItem, txtLuongCBNV.Text);
                LVItem.SubItems.Add(LVSItemCV);
                LVItem.SubItems.Add(LVSItemHSL);
                LVItem.SubItems.Add(LVSItemLCB);
                listNhanVien.Items.Add(LVItem);

                txtLuongCBNV.Text = "";
                txtHoTenNV.Text = "";
                txtHeSoLuongNV.Text = "";
                txtChucVuNV.Text = "";
            }
            else
                MessageBox.Show("Phải nhập đầy đủ thông tin nhân viên");
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listNhanVien.SelectedItems)
            {
                lvi.SubItems[0].Text = txtHoTenNV.Text;
                lvi.SubItems[1].Text = txtChucVuNV.Text;
                lvi.SubItems[2].Text = txtHeSoLuongNV.Text;
                lvi.SubItems[3].Text = txtLuongCBNV.Text;
            }
        }

        

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (listNhanVien.SelectedIndices.Count > 0)
            {
                listNhanVien.Items.RemoveAt(listNhanVien.FocusedItem.Index);
            }
            else
                MessageBox.Show("Phải chọn nhân viên muốn xóa");
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            if (txtHoTenGV.Text != "" && txtHocVi.Text != "" &&
                txtTienDayMotTiet.Text != "" && txtSoTietDay.Text != "")
            {
                ListViewItem LVItem = new ListViewItem(txtHoTenGV.Text);
                ListViewItem.ListViewSubItem LVSItemHV = new ListViewItem.ListViewSubItem(LVItem, txtHocVi.Text);
                ListViewItem.ListViewSubItem LVSItemTD = new ListViewItem.ListViewSubItem(LVItem, txtTienDayMotTiet.Text);
                ListViewItem.ListViewSubItem LVSItemST = new ListViewItem.ListViewSubItem(LVItem, txtSoTietDay.Text);
                LVItem.SubItems.Add(LVSItemHV);
                LVItem.SubItems.Add(LVSItemTD);
                LVItem.SubItems.Add(LVSItemST);
                listGiaoVien.Items.Add(LVItem);

                txtHoTenGV.Text = "";
                txtHocVi.Text = "";
                txtTienDayMotTiet.Text = "";
                txtSoTietDay.Text = "";
            }
            else
                MessageBox.Show("Phải nhập đầy đủ thông tin giáo viên");
        }

        private void btnCapNhatGV_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listGiaoVien.SelectedItems)
            {
                lvi.SubItems[0].Text = txtHoTenGV.Text;
                lvi.SubItems[1].Text = txtHocVi.Text;
                lvi.SubItems[2].Text = txtTienDayMotTiet.Text;
                lvi.SubItems[3].Text = txtSoTietDay.Text;
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (listGiaoVien.SelectedIndices.Count > 0)
            {
                listGiaoVien.Items.RemoveAt(listGiaoVien.FocusedItem.Index);
            }
            else
                MessageBox.Show("Phải chọn giáo viên muốn xóa");
        }

        private void listNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listNhanVien.SelectedItems.Count == 0)
                return;

            ListViewItem lvi = listNhanVien.SelectedItems[0];
            txtHoTenNV.Text = lvi.SubItems[0].Text;
            txtChucVuNV.Text = lvi.SubItems[1].Text;
            txtHeSoLuongNV.Text = lvi.SubItems[2].Text;
            txtLuongCBNV.Text = lvi.SubItems[3].Text;
        }

        private void listGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGiaoVien.SelectedItems.Count == 0)
                return;

            ListViewItem lvi = listGiaoVien.SelectedItems[0];
            txtHoTenGV.Text = lvi.SubItems[0].Text;
            txtHocVi.Text = lvi.SubItems[1].Text;
            txtTienDayMotTiet.Text = lvi.SubItems[2].Text;
            txtSoTietDay.Text = lvi.SubItems[3].Text;
        }
    }
}
