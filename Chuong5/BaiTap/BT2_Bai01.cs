using LapTrinhWindowsForm.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong5.BaiTap
{
    public partial class BT2_Bai01 : Form
    {
        public BT2_Bai01()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = BusinessConstraints.ChuoiKhongRong(txtHoTen.Text, "họ tên");

            if (hoTen == null)
                return;

            if (!BusinessConstraints.DaChonComboBox(cboLop, "lớp"))
                return;

            string hocBong = BusinessConstraints.ChuoiKhongRong(txtHocBong.Text, "học bổng");

            if (hocBong == null)
                return;

            ListViewItem dong = new ListViewItem(hoTen);
            dong.SubItems.Add(cboLop.Text);
            dong.SubItems.Add(hocBong);
            lvDanhSach.Items.Add(dong);

            txtHoTen.Text = "";
            cboLop.SelectedIndex = -1;
            txtHocBong.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống, chưa có gì để lưu");
                return;
            }

            using (StreamWriter sw = new StreamWriter("DS.txt"))
            // using: đảm bảo file được đóng (Dispose) ngay cả khi có lỗi xảy ra giữa chừng khi ghi
            {
                foreach (ListViewItem dong in lvDanhSach.Items)
                {
                    string hoTen = dong.SubItems[0].Text;
                    string lop = dong.SubItems[1].Text;
                    string hocBong = dong.SubItems[2].Text;

                    sw.WriteLine(hoTen + " - " + lop + " - " + hocBong);
                    // WriteLine: ghi 1 dòng rồi tự xuống dòng, đúng định dạng mỗi sinh viên 1 dòng như Hình 5.39
                }
            }

            MessageBox.Show("Đã lưu thành công vào file DS.txt");
        }
    }
}
