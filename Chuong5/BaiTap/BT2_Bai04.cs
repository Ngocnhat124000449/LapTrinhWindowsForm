using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong5.BaiTap
{
    public partial class BT2_Bai04 : Form
    {
        private bool dangVe = false;
        private Point diemTruoc;
        public BT2_Bai04()
        {
            InitializeComponent();
        }

        private void BT2_Bai04_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;
                diemTruoc = e.Location;
            }
        }

        private void BT2_Bai04_MouseMove(object sender, MouseEventArgs e)
        {
            if (dangVe)
            {
                Graphics g = this.CreateGraphics();
                // CreateGraphics: lấy bề mặt vẽ của form hiện tại để vẽ trực tiếp lên đó

                Pen but = new Pen(Color.Firebrick, 2);
                // Firebrick: màu đỏ nâu gần giống ảnh minh họa Hình 5.44; độ dày nét 2

                g.DrawLine(but, diemTruoc, e.Location);
                // nối đoạn thẳng từ điểm trước đến vị trí chuột hiện tại — lặp lại liên tục khi di chuột
                // tạo cảm giác 1 nét vẽ liền mạch, thay vì phải vẽ cả đường cong phức tạp

                diemTruoc = e.Location;
                // cập nhật điểm trước thành vị trí vừa vẽ tới, chuẩn bị cho đoạn thẳng tiếp theo

                but.Dispose();
                g.Dispose();
                // Dispose(): giải phóng tài nguyên GDI+ ngay sau khi dùng xong — Pen và Graphics
                // không tự động giải phóng, nếu bỏ sót sẽ rò rỉ tài nguyên khi vẽ liên tục nhiều lần
            }
        }

        private void BT2_Bai04_MouseUp(object sender, MouseEventArgs e)
        {
            dangVe = false;
        }
    }
}
