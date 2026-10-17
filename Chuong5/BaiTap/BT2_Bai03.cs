using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong5.BaiTap
{
    public partial class BT2_Bai03 : Form
    {
        public BT2_Bai03()
        {
            InitializeComponent();
        }
        private void CapNhatThongTin()
        // cập nhật toàn bộ ô kết quả theo giá trị đang chọn trên dtpBanChon — dùng chung cho Load và ValueChanged
        {
            txtNgayHienTai.Text = DateTime.Now.ToShortDateString();
            // DateTime.Now: ngày thực của máy tính, không phụ thuộc vào dtpBanChon

            txtNgay.Text = dtpBanChon.Value.Day.ToString();
            txtThang.Text = dtpBanChon.Value.Month.ToString();
            txtNam.Text = dtpBanChon.Value.Year.ToString();
            txtThu.Text = ((int)dtpBanChon.Value.DayOfWeek + 1).ToString();
            // DayOfWeek trả về enum bắt đầu từ Sunday = 0; +1 để khớp cách gọi "Thứ 2"..."Thứ 7", "Chủ nhật" = 1

            txtNgayCuaNam.Text = dtpBanChon.Value.DayOfYear.ToString();
            // DayOfYear: thứ tự ngày tính từ đầu năm (1/1 là ngày thứ 1)
        }

        private void BT2_Bai03_Load(object sender, EventArgs e)
        {
            CapNhatThongTin();
        }

        private void dtpBanChon_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThongTin();
        }

        private void lnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lhu.edu.vn");
        }

        private void lnkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
