using LapTrinhWindowsForm.Constraints;
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

namespace LapTrinhWindowsForm.Chuong4.ViDu
{
    public partial class VD4 : Form
    {
        public VD4()
        {
            InitializeComponent();
        }

        private void btnThemGoc_Click(object sender, EventArgs e)
        {
            string tieuDe = BusinessConstraints.ChuoiKhongRong(txtTieuDe.Text, "tiêu đề node");

            if (tieuDe == null)
                return;

            TV_Test.Nodes.Add(tieuDe);
            txtTieuDe.Text = "";
        }

        private void btnThemCon_Click(object sender, EventArgs e)
        {
            if (TV_Test.SelectedNode == null)
            // SelectedNode = null nghĩa là chưa chọn node gốc nào để thêm node con vào
            {
                MyExtentions.ThongBao(this, "Chưa chọn node để thêm node con");
                return;
            }

            string tieuDe = BusinessConstraints.ChuoiKhongRong(txtTieuDe.Text, "tiêu đề node");

            if (tieuDe == null)
                return;

            TV_Test.SelectedNode.Nodes.Add(tieuDe);
            txtTieuDe.Text = "";
            TV_Test.ExpandAll();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (TV_Test.SelectedNode == null)
            {
                MyExtentions.ThongBao(this, "Chưa chọn node cần xóa");
                return;
            }

            TV_Test.SelectedNode.Remove();
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            TV_Test.Nodes.Clear();
        }

        private void btnMoRong_Click(object sender, EventArgs e)
        {
            TV_Test.ExpandAll();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            TV_Test.CollapseAll();
        }
    }
}
