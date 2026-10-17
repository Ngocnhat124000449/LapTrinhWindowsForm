using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.utilities
{
    internal class MyExtentions
    {

        public static bool XacNhanThoat(IWin32Window owner)
        // trả về true nếu người dùng chọn OK (muốn thoát), false nếu Cancel
        {
            CenterWinDialog.ChuanBiCanhGiua(owner);
            DialogResult ketQua = MessageBox.Show(
                owner,
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            return ketQua == DialogResult.OK;
        }
        public static void ThongBao(IWin32Window owner, string noiDung, string tieuDe = "Thông báo")
        {
            CenterWinDialog.ChuanBiCanhGiua(owner);
            MessageBox.Show(owner, noiDung, tieuDe);
        }

        public static DialogResult ThongBao(IWin32Window owner, string noiDung, string tieuDe, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            CenterWinDialog.ChuanBiCanhGiua(owner);
            return MessageBox.Show(owner, noiDung, tieuDe, buttons, icon);
        }
    }
}
