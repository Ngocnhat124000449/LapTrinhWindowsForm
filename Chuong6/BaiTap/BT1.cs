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

namespace LapTrinhWindowsForm.Chuong6.BaiTap
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void btnPhatSinh_Click(object sender, EventArgs e)
        {
            long? tongNut = BusinessConstraints.SoNguyenToiThieu(txtTongNut.Text, lblTongNut.Text, 1    );
            if (tongNut == null) return;
            long? nutHang = BusinessConstraints.SoNguyenToiThieu(txtNutHang.Text, lblNutHang.Text,1);
            if (nutHang == null) return;

            panel1.Controls.Clear();
            int chieuRong = 55;
            int chieuCao = 30;
            int khoangCach = 10;
            int leTrai = 10;
            int leTren = 10;

            for (int i = 1; i <= tongNut.Value; i++)
            {
                int chiSo = i - 1;
                int soCot = chiSo % (int)nutHang.Value;
                int soHang = chiSo / (int)nutHang.Value;

                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Size = new Size(chieuRong, chieuCao);
                btn.Location = new Point(
                    leTrai + soCot * (chieuRong + khoangCach),
                    leTren + soHang * (chieuCao + khoangCach));
                btn.Click += new EventHandler(Button_Click);
                panel1.Controls.Add(btn);
            }
            
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btnNhanDuoc = (Button)sender;
            int soNut = int.Parse(btnNhanDuoc.Text);
            if (soNut == 10) MyExtentions.ThongBao(this, "Bạn đã trúng 01 tỉ USD");
            else MyExtentions.ThongBao(this, "Bạn vừa nhấn nút: " + soNut);
        }
    }
}
