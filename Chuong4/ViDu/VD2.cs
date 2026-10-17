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
    public partial class VD2 : Form
    {
        private int a = 0;
        private int b = 0;
        private float x = 0;
        private Random rd = new Random();
        public VD2()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            float kq = float.Parse(txtX.Text);

            if (Math.Abs(kq - x) < 0.01)
            // Math.Abs: so sánh gần đúng, vì x tính từ phép chia số thực có thể lệch phần thập phân rất nhỏ
            {
                MyExtentions.ThongBao(this, "Bạn đã làm đúng");
                this.Close();
            }
            else
                MyExtentions.ThongBao(this, "Bạn đã trả lời sai");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }

        private void VD2_Load(object sender, EventArgs e)
        {
            a = rd.Next(-10, 10);
            txtA.Text = a.ToString();

            b = rd.Next(-10, 10);
            txtB.Text = b.ToString();

            x = -b / (float)a;
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            if (ProGressTG.Value == 30000)
            {
                ThoiGian.Enabled = false;
                MyExtentions.ThongBao(this, "Hết giờ làm bài");
            }

            ProGressTG.PerformStep();
        }
    }
    
}
