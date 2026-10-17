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
    public partial class BT1 : Form
    {
        private int buocTang = 0;
        public BT1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            long? tang = BusinessConstraints.SoNguyenToiThieu(txtIncrement.Text, "Increment", 1);

            if (tang == null)
                return;

            long? khoangCach = BusinessConstraints.SoNguyenToiThieu(txtInterval.Text, "Seconds Interval", 1);

            if (khoangCach == null)
                return;

            buocTang = (int)tang.Value;
            tmrDem.Interval = (int)khoangCach.Value;
            // giá trị txtInterval dùng trực tiếp làm Interval (đơn vị mili giây),
            // "Seconds Interval (/1000 giây)" trong đề chỉ là chú thích quy đổi ra giây cho người đọc

            txtIncrement.ReadOnly = true;
            txtInterval.ReadOnly = true;
            tmrDem.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrDem.Enabled = false;

            txtIncrement.ReadOnly = false;
            txtInterval.ReadOnly = false;
            txtIncrement.Text = "";
            txtInterval.Text = "";

            ProgressBar1.Value = ProgressBar1.Minimum;
            lbValue.Text = "Value";
        }

        private void tmrDem_Tick(object sender, EventArgs e)
        {
            int giaTriMoi = ProgressBar1.Value + buocTang;

            if (giaTriMoi >= ProgressBar1.Maximum)
                giaTriMoi = ProgressBar1.Minimum;
            // đúng yêu cầu: Value >= Maximum thì quay về Minimum, không dừng lại ở Maximum

            ProgressBar1.Value = giaTriMoi;
            lbValue.Text = ProgressBar1.Value.ToString();
        }
    }
}
