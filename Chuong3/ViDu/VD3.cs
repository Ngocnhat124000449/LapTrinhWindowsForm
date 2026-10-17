using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapTrinhWindowsForm.utilities;
namespace LapTrinhWindowsForm.Chuong3.ViDu
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int viTri = txtNoiDung.Text.IndexOf(txtChuoiCanTim.Text);
            // IndexOf: trả về vị trí ký tự đầu tiên của chuỗi tìm trong txtNoiDung, -1 nếu không tìm thấy

            if (viTri >= 0)
            {
                txtNoiDung.SelectionStart = viTri;
                // SelectionStart: vị trí bắt đầu bôi đen trong TextBox

                txtNoiDung.SelectionLength = txtChuoiCanTim.Text.Length;
                // SelectionLength: độ dài đoạn cần bôi đen, bằng đúng độ dài chuỗi tìm

                MessageBox.Show(txtNoiDung.SelectedText);
                // SelectedText: lấy ra đúng đoạn chuỗi vừa bôi đen để hiển thị
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
    }
}
