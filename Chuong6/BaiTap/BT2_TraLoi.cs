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
    public partial class BT2_TraLoi : Form
    {
        private int viTriDapAnDung;
        public BT2_TraLoi()
        {
            InitializeComponent();
        }
        public BT2_TraLoi(string cauHoi, List<string> dsDapAn, int viTriDung)
        {
            InitializeComponent();
            lblNoiDungCauHoi.Text = cauHoi;
            viTriDapAnDung = viTriDung;


            for (int i = 0; i < dsDapAn.Count; i++)
            {
                RadioButton rad = new RadioButton();
                rad.Text = dsDapAn[i];
                rad.AutoSize = true;
                rad.Tag = 1;

                flowLayoutPanel1.Controls.Add(rad);
            }
        }
        private void btnTraLoi_Click(object sender, EventArgs e)
        {
            int viTriDachon = -1;
            foreach (Control ctl in flowLayoutPanel1.Controls)
            {
                if (ctl is RadioButton rad && rad.Checked)
                {
                    viTriDachon = (int)rad.Tag;
                    break;
                }
            }
            if (viTriDachon == -1)
            {
                MyExtentions.ThongBao(this, "Phải chọn một đáp án");
                return;
            }
            if (viTriDachon == viTriDapAnDung) MyExtentions.ThongBao(this, "Bạn đã trả lời đúng");
            else MyExtentions.ThongBao(this, "Bạn đã trả lời sai");
        }
    }
}
