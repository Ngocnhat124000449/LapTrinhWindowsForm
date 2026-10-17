using LapTrinhWindowsForm.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong4.BaiTap
{
    public partial class BT4 : Form
    {
        public BT4()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            tvThuMuc.Nodes.Clear();

            foreach (DriveInfo oDia in DriveInfo.GetDrives())
            // DriveInfo.GetDrives(): liệt kê toàn bộ ổ đĩa của máy (C:, D:, E:...)
            {
                if (!oDia.IsReady)
                    // IsReady = false: ổ đĩa không sẵn sàng (vd: ổ CD/DVD trống) — bỏ qua để tránh lỗi khi đọc
                    continue;

                TreeNode nodeGoc = new TreeNode(oDia.Name);
                nodeGoc.Tag = oDia.RootDirectory.FullName;
                // Tag: lưu đường dẫn thật của node — dùng lại khi mở rộng (BeforeExpand) để biết đọc thư mục nào

                nodeGoc.Nodes.Add(new TreeNode());
                // thêm 1 node giả (rỗng) — khiến TreeView hiện dấu "+" dù chưa đọc thư mục con thật,
                // đây là cốt lõi của lazy load: giả vờ có con để cho phép mở rộng

                tvThuMuc.Nodes.Add(nodeGoc);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this))
                this.Close();
        }
        private void tvThuMuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode nodeDangMo = e.Node;

            if (nodeDangMo.Nodes.Count == 1 && nodeDangMo.Nodes[0].Text == "")
            // đúng 1 node con VÀ node đó rỗng — chắc chắn đây là node giả, chưa từng tải thư mục con thật
            {
                nodeDangMo.Nodes.Clear();
                // xóa node giả trước khi nạp danh sách thư mục con thật vào

                string duongDan = nodeDangMo.Tag.ToString();

                try
                {
                    foreach (string duongDanCon in Directory.GetDirectories(duongDan))
                    // GetDirectories: lấy danh sách thư mục con cấp 1, không đệ quy sâu hơn — đúng tinh thần lazy load
                    {
                        TreeNode nodeCon = new TreeNode(Path.GetFileName(duongDanCon));
                        // Path.GetFileName: lấy đúng tên thư mục cuối cùng trong đường dẫn, không phải cả đường dẫn

                        nodeCon.Tag = duongDanCon;

                        if (Directory.GetDirectories(duongDanCon).Length > 0)
                            // chỉ thêm node giả nếu thư mục này thật sự còn thư mục con bên trong,
                            // tránh hiện dấu "+" vô nghĩa cho thư mục rỗng (như "Nhạc", "Hình ảnh" trong ảnh)
                            nodeCon.Nodes.Add(new TreeNode());

                        nodeDangMo.Nodes.Add(nodeCon);
                    }
                }
                catch (UnauthorizedAccessException)
                // một số thư mục hệ thống (System Volume Information...) chặn quyền đọc — bỏ qua thay vì crash
                {
                }
            }
        }
    }
}
