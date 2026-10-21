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
    public partial class VD4 : Form
    {
        public VD4()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }

        private void VD4_Load(object sender, EventArgs e)
        {
            myWebsite.Navigate("www.google.com");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem liv = new ListViewItem(txtLink.Text);
            listLinkWebsite.Items.Add(liv);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            listLinkWebsite.FocusedItem.Text = txtLink.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int i = listLinkWebsite.FocusedItem.Index;
            //listLinkWebsite.Items.RemoveAt(i);
            //txtLink.Text = "";
            //myWebsite.Navigate("www.google.com");
            if (listLinkWebsite.SelectedItems.Count == 0)
            {
                MessageBox.Show("Phải chọn một đường dẫn cần xóa");
                return;
            }
            listLinkWebsite.Items.Remove(listLinkWebsite.SelectedItems[0]);
        }

        private void listLinkWebsite_MouseClick(object sender, MouseEventArgs e)
        {
            //txtLink.Text = listLinkWebsite.FocusedItem.Text;
            //if (e.Button == MouseButtons.Left) myWebsite.Navigate(listLinkWebsite.FocusedItem.Text);
            if (listLinkWebsite.SelectedItems.Count == 0) return;
            myWebsite.Navigate(listLinkWebsite.SelectedItems[0].Text);
        }
    }
}
