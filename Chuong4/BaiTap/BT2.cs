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

namespace LapTrinhWindowsForm.Chuong4.BaiTap
{
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            string chuoi = BusinessConstraints.ChuoiKhongRong(txtChuoi.Text, "chuỗi");

            if (chuoi == null)
                return;

            txtChuoi.Text = BusinessConstraints.ChuanHoaChuoi(chuoi);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string chuoi = BusinessConstraints.ChuoiKhongRong(txtChuoi.Text, "chuỗi");

            if (chuoi == null)
                return;

            var thongKe = BusinessConstraints.ThongKeTuDonKhongPhanBiet(chuoi);

            lvThongKe.Items.Clear();

            foreach (var cap in thongKe)
            {
                ListViewItem dong = new ListViewItem(cap.Key);
                dong.SubItems.Add(cap.Value.ToString());
                lvThongKe.Items.Add(dong);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu thành công");
            Application.Exit();
        }

        private void BT2_Load(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
               "Bạn có muốn tiếp tục Load Form?",
               "Nguyễn Ngọc Nhật - 01",
               MessageBoxButtons.YesNo);

            if (ketQua == DialogResult.No)
                this.Close();
        }
    }
}
