using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong2
{
    public partial class BT6 : Form
    {
        public BT6()
        {
            InitializeComponent();
        }

        private void BT6_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            // GraphicsPath: tập hợp các đoạn thẳng/đường cong tạo thành 1 hình dạng tùy ý

            path.AddPolygon(new Point[]
            {
                new Point(0, 0),              // góc trên-trái: đỉnh vuông của tam giác
                new Point(this.Width, 0),     // góc trên-phải
                new Point(0, this.Height)     // góc dưới-trái
            });
            // 3 điểm này tạo tam giác vuông với cạnh huyền chạy từ trên-phải xuống dưới-trái,
            // đúng hình dạng trong ảnh 2.21: góc vuông nằm ở trên-trái, nơi có titlebar

            this.Region = new Region(path);
            // Region: giới hạn vùng hiển thị thật của form theo hình path — phần ngoài tam giác bị cắt bỏ hoàn toàn
        }
    }
}
