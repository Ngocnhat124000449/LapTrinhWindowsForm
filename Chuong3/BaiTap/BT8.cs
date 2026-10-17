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

namespace LapTrinhWindowsForm.Chuong3.BaiTap
{
    public partial class BT8 : Form
    {
        public BT8()
        {
            InitializeComponent();
        }
        private bool dangMo = false;
        private double soA = 0;
        private string phepToanDangCho = "";

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            dangMo = !dangMo;
            KichHoatCacNut(dangMo);
            if (dangMo)
            {
                txtManHinh.Focus();
                txtManHinh.SelectionStart = txtManHinh.Text.Length;
            }
        }
        private void NhapChuSo(string chuSo)
        {
            if (!BusinessConstraints.MayDaMo(dangMo)) return;
            txtManHinh.Text = txtManHinh.Text + chuSo;
        }

        private void btnXoaMot_Click(object sender, EventArgs e)
        {
            if (!BusinessConstraints.MayDaMo(dangMo)) return;
            char kyTuCuoi = txtManHinh.Text[txtManHinh.Text.Length - 1];
            txtManHinh.Text = txtManHinh.Text.Substring(0, txtManHinh.Text.Length - 1);

            if (kyTuCuoi == '.')
                btnDauCham.Enabled = true;
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (!BusinessConstraints.MayDaMo(dangMo)) return;

            txtManHinh.Text = "";
            btnDauCham.Enabled = true;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if(!BusinessConstraints.MayDaMo(dangMo)) return;

            if (string.IsNullOrEmpty(phepToanDangCho))
                return;
            // chưa bấm phép toán nào thì không có gì để tính

            double soB = BusinessConstraints.TextToNumber(txtManHinh.Text);
            double? ketQua = null;

            switch (phepToanDangCho)
            {
                case "+":
                    ketQua = soA + soB;
                    break;
                case "-":
                    ketQua = soA - soB;
                    break;
                case "*":
                    ketQua = soA * soB;
                    break;
                case "/":
                    ketQua = BusinessConstraints.ChiaAnToan(soA, soB);
                    break;
            }

            if (ketQua == null)
                return;
            // chia cho 0 — MessageBox đã hiện sẵn trong ChiaAnToan

            txtManHinh.Text = ketQua.Value.ToString();
            phepToanDangCho = "";
            btnDauCham.Enabled = !BusinessConstraints.CoDauCham(txtManHinh.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NhapChuSo("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NhapChuSo("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NhapChuSo("9");
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            XuLyPhepToan("+");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NhapChuSo("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NhapChuSo("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NhapChuSo("6");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            XuLyPhepToan("-");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NhapChuSo("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NhapChuSo("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NhapChuSo("3");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            XuLyPhepToan("*");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NhapChuSo("0");
        }

        private void btnDauCham_Click(object sender, EventArgs e)
        {
            if (!BusinessConstraints.MayDaMo(dangMo)) return;

            txtManHinh.Text = txtManHinh.Text + ".";
            btnDauCham.Enabled = !BusinessConstraints.CoDauCham(txtManHinh.Text);
        }

        private void btnDoiDau_Click(object sender, EventArgs e)
        {
            if (!BusinessConstraints.MayDaMo(dangMo)) return;

            txtManHinh.Text = BusinessConstraints.DoiDau(txtManHinh.Text);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            XuLyPhepToan("/");
        }

        private void BT8_Load(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "124000449 - Nguyễn Ngọc Nhật",
                "Thông tin sinh viên",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            if (kq == DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            KichHoatCacNut(dangMo);
        }
        private void KichHoatCacNut(bool batTat)
        {
            btn0.Enabled = batTat;
            btn1.Enabled = batTat;
            btn2.Enabled = batTat;
            btn3.Enabled = batTat;
            btn4.Enabled = batTat;
            btn5.Enabled = batTat;
            btn6.Enabled = batTat;
            btn7.Enabled = batTat;
            btn8.Enabled = batTat;
            btn9.Enabled = batTat;
            btnCong.Enabled = batTat;
            btnTru.Enabled = batTat;
            btnNhan.Enabled = batTat;
            btnChia.Enabled = batTat;
            btnBang.Enabled = batTat;
            btnXoaMot.Enabled = batTat;
            btnXoaTatCa.Enabled = batTat;
            btnDoiDau.Enabled = batTat;

            btnDauCham.Enabled = batTat && !BusinessConstraints.CoDauCham(txtManHinh.Text);
        }
        private void XuLyPhepToan(string phepToan)
        // dùng chung cho 4 nút +,-,*,/ — lưu số A, ghi nhớ phép toán, xóa màn hình chờ nhập số B
        {
            if (!BusinessConstraints.MayDaMo(dangMo)) return;

            soA = BusinessConstraints.TextToNumber(txtManHinh.Text);
            phepToanDangCho = phepToan;
            txtManHinh.Text = "";
            btnDauCham.Enabled = true;
        }
    }
}
