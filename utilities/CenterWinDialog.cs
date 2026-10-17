using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.utilities
{
    internal static class CenterWinDialog
    {
        private const int WH_CBT = 5;
        private const int HCBT_ACTIVATE = 5;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOZORDER = 0x0004;

        private static IntPtr hHook = IntPtr.Zero;
        private static HookProc hookProc;
        private static Rectangle vungOwner;
        // vungOwner: tọa độ + kích thước thật của form cha trên màn hình, lấy trước khi MessageBox xuất hiện

        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern int GetCurrentThreadId();

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT { public int Left, Top, Right, Bottom; }

        public static void ChuanBiCanhGiua(IWin32Window owner)
        // gọi NGAY TRƯỚC MessageBox.Show — cài hook để bắt thời điểm MessageBox vừa tạo ra
        {
            GetWindowRect(owner.Handle, out RECT rect);
            vungOwner = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);

            hookProc = new HookProc(MessageBoxHookProc);
            hHook = SetWindowsHookEx(WH_CBT, hookProc, IntPtr.Zero, GetCurrentThreadId());
        }

        private static IntPtr MessageBoxHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        // wParam: handle của cửa sổ vừa được Windows kích hoạt — khi đó chính là MessageBox vừa hiện
        {
            if (nCode == HCBT_ACTIVATE)
            {
                GetWindowRect(wParam, out RECT msgRect);
                int rong = msgRect.Right - msgRect.Left;
                int cao = msgRect.Bottom - msgRect.Top;

                int x = vungOwner.Left + (vungOwner.Width - rong) / 2;
                int y = vungOwner.Top + (vungOwner.Height - cao) / 2;
                // tọa độ giữa vùng form owner, không phải giữa màn hình

                SetWindowPos(wParam, IntPtr.Zero, x, y, 0, 0, SWP_NOSIZE | SWP_NOZORDER);

                UnhookWindowsHookEx(hHook);
                // gỡ hook ngay sau khi dùng — hook chỉ cần bắt đúng 1 lần cho MessageBox này
                hHook = IntPtr.Zero;
            }

            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }
    }
}