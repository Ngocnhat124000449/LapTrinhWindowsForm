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

namespace LapTrinhWindowsForm.Chuong3.ViDu
{
    public partial class VD4 : Form
    {
        public VD4()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string str = "";

            foreach (string item in listBox1.SelectedItems)
            // SelectedItems: tập hợp các mục đang được chọn trong listBox1 (nhiều mục nếu SelectionMode = MultiExtended)
            {
                str = str + item + "; ";
            }

            MessageBox.Show(str);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }
    }
}
