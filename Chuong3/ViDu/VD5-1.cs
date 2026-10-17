using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong3.ViDu
{
    public partial class VD5_1 : Form
    {
        public VD5_1()
        {
            InitializeComponent();
        }
        private void ThietLapViTriComboBox()
        // nạp lại danh sách chỉ số (0, 1, 2...) vào cboViTri, tương ứng số lượng sản phẩm hiện có
        {
            cboViTri.Items.Clear();
            int chiso = DSSanPham.Items.Count;

            for (int i = 0; i < chiso; i++)
                cboViTri.Items.Add(i.ToString());
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtThemSP.Text.Trim() != "")
            {
                DSSanPham.Items.Add(txtThemSP.Text);
                txtThemSP.Text = "";
                ThietLapViTriComboBox();
                // nạp lại cboViTri vì số lượng sản phẩm vừa tăng thêm 1
            }
            else
                MessageBox.Show("Phải nhập tên sản phẩm");

        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if (txtThemSPViTri.Text.Trim() != "")
            {
                if (cboViTri.Text != "")
                {
                    DSSanPham.Items.Insert(Convert.ToInt32(cboViTri.Text), txtThemSPViTri.Text);
                    // Insert(vị trí, giá trị): chèn sản phẩm vào đúng chỉ số được chọn trong cboViTri,
                    // các phần tử từ vị trí đó trở về sau bị đẩy lùi xuống 1 bậc

                    txtThemSPViTri.Text = "";
                    ThietLapViTriComboBox();
                }
                else
                    MessageBox.Show("Phải chọn vị trí thêm hợp lệ");
            }
            else
                MessageBox.Show("Phải nhập tên sản phẩm ");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimSP.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập sản phẩm cần tìm");
                return;
            }

            if (DSSanPham.Items.Contains(txtTimSP.Text))
                MessageBox.Show("Tìm thấy sản phẩm");
            else
                MessageBox.Show("Không tìm thấy sản phẩm");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DSSanPham.SelectedIndex != -1)
            // SelectedIndex = -1 nghĩa là chưa chọn sản phẩm nào trong danh sách
            {
                DSSanPham.Items.RemoveAt(DSSanPham.SelectedIndex);
                ThietLapViTriComboBox();
                // nạp lại cboViTri vì số lượng sản phẩm vừa giảm đi 1
            }
            else
                MessageBox.Show("Phải chọn sản phẩm cần xóa");

        }

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            if (DSSanPham.Items.Count > 0)
                DSSanPham.Items.Clear();
            else
                MessageBox.Show("Danh sách sản phẩm chưa có gì");
        }

        private void VD5_1_Load(object sender, EventArgs e)
        {
            ThietLapViTriComboBox();
        }
    }
}
