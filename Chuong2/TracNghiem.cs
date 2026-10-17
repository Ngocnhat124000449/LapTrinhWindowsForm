using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LapTrinhWindowsForm.utilities;

namespace LapTrinhWindowsForm.Chuong2
{
    public partial class TracNghiem : Form
    {
        private class CauHoi
        // class riêng chứa cấu trúc 1 câu hỏi — chỉ dùng nội bộ trong TracNghiem, không cần đưa ra ngoài
        {
            public string NoiDung;              // nội dung câu hỏi
            public string[] DapAn;               // mảng các lựa chọn, số lượng 4-6 tùy câu
            public int ViTriDung;                // chỉ số (0-based) của đáp án đúng trong mảng DapAn
        }

        private List<CauHoi> danhSachCauHoi;
        private int chiSoHienTai = 0;
        // chiSoHienTai: vị trí câu hỏi đang hiển thị trong danhSachCauHoi, bắt đầu từ câu đầu tiên

        public TracNghiem()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
            HienThiCauHoi();
        }

        private void KhoiTaoDuLieu()
        // nạp 5 câu hỏi từ mục 2.3 Bài tập cuối chương (Chuong 2.pdf) vào danhSachCauHoi
        {
            danhSachCauHoi = new List<CauHoi>
            {
                new CauHoi
                {
                    NoiDung = "Câu 1: Trong các dòng mã lệnh sau đây, mã lệnh nào cho phép tạo và hiển thị một đối tượng Windows Form mới có tên là Form1?",
                    DapAn = new string[]
                    {
                        "a) Form1 frm = new Form1; frm.Show();",
                        "b) Form Form1 = new Form(); Form1.Show();",
                        "c) Form1 frm; frm.Show();",
                        "d) Form frm; frm.Show();",
                        "e) Form Form1 = new Form(); Form1.ShowDialog();"
                    },
                    ViTriDung = 1 // đáp án b
                },
                new CauHoi
                {
                    NoiDung = "Câu 2: Thuộc tính nào dùng để thiết lập nội dung hiển thị trên thanh title bar và thuộc tính nào dùng để thiết lập màu nền của form?",
                    DapAn = new string[]
                    {
                        "a) Thuộc tính Text và ForeColor",
                        "b) Thuộc tính Display và BackColor",
                        "c) Thuộc tính Text và BackColor",
                        "d) Thuộc tính Display và ForeColor"
                    },
                    ViTriDung = 2 // đáp án c
                },
                new CauHoi
                {
                    NoiDung = "Câu 3: Thuộc tính nào cho phép thiết lập form trở thành Mdi Form?",
                    DapAn = new string[]
                    {
                        "a) IsMdiContainer",
                        "b) MdiParent",
                        "c) MdiContainer",
                        "d) ParentForm"
                    },
                    ViTriDung = 0 // đáp án a
                },
                new CauHoi
                {
                    NoiDung = "Câu 4: Thuộc tính nào cho phép thiết lập form trở thành Child Form?",
                    DapAn = new string[]
                    {
                        "a) IsMdiContainer",
                        "b) MdiParent",
                        "c) MdiContainer",
                        "d) ParentForm"
                    },
                    ViTriDung = 1 // đáp án b
                },
                new CauHoi
                {
                    NoiDung = "Câu 5: Trong các sự kiện sau, sự kiện nào sẽ phát sinh khi form đã đóng?",
                    DapAn = new string[]
                    {
                        "a) FormClosed",
                        "b) FormClosing",
                        "c) ClosedForm",
                        "d) ClosingForm",
                        "e) Load",
                        "f) Click"
                    },
                    ViTriDung = 0 // đáp án a
                }
            };
        }

        private void HienThiCauHoi()
        // cập nhật toàn bộ label theo câu hỏi tại chiSoHienTai, tô đậm + đổi màu đáp án đúng
        {
            CauHoi cauHienTai = danhSachCauHoi[chiSoHienTai];

            lblSoThuTu.Text = "Câu " + (chiSoHienTai + 1) + "/" + danhSachCauHoi.Count;
            lblCauHoi.Text = cauHienTai.NoiDung;

            Label[] nhanDapAn = { lblDapAn1, lblDapAn2, lblDapAn3, lblDapAn4, lblDapAn5, lblDapAn6 };
            // gom 6 label vào mảng để duyệt vòng lặp thay vì viết lặp lại 6 lần

            for (int i = 0; i < nhanDapAn.Length; i++)
            {
                if (i < cauHienTai.DapAn.Length)
                // còn lựa chọn thứ i trong câu hỏi hiện tại
                {
                    nhanDapAn[i].Visible = true;
                    nhanDapAn[i].Text = cauHienTai.DapAn[i];

                    if (i == cauHienTai.ViTriDung)
                    // đây là đáp án đúng: tô đậm + màu xanh lá để phân biệt
                    {
                        nhanDapAn[i].Font = new Font(nhanDapAn[i].Font, FontStyle.Bold);
                        nhanDapAn[i].ForeColor = Color.Green;
                    }
                    else
                    {
                        nhanDapAn[i].Font = new Font(nhanDapAn[i].Font, FontStyle.Regular);
                        nhanDapAn[i].ForeColor = Color.Black;
                    }
                }
                else
                // câu hỏi hiện tại không có đủ 6 lựa chọn: ẩn label thừa
                {
                    nhanDapAn[i].Visible = false;
                }
            }

            btnCauTruoc.Enabled = chiSoHienTai > 0;
            // vô hiệu nút Câu trước khi đang ở câu đầu tiên

            btnCauTiep.Enabled = chiSoHienTai < danhSachCauHoi.Count - 1;
            // vô hiệu nút Câu tiếp khi đang ở câu cuối cùng
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            if (chiSoHienTai > 0)
            {
                chiSoHienTai--;
                HienThiCauHoi();
            }
        }

        private void btnCauTiep_Click(object sender, EventArgs e)
        {
            if (chiSoHienTai < danhSachCauHoi.Count - 1)
            {
                chiSoHienTai++;
                HienThiCauHoi();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }
    }
}