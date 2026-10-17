using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using LapTrinhWindowsForm.Constraints;
using LapTrinhWindowsForm.utilities;

namespace LapTrinhWindowsForm.Constraints
{
    internal class BusinessConstraints
    {

        public static double? NhapSoThucDuong(string chuoiNhap, string tenTruong)
        // chuoiNhap: giá trị thô lấy từ TextBox; tenTruong: tên hiển thị trong thông báo lỗi (vd: "Chiều dài")
        // trả về double? — null khi dữ liệu không hợp lệ ở bất kỳ bước nào, để form chỉ cần kiểm tra null
        {
            if (string.IsNullOrWhiteSpace(chuoiNhap))
            // IsNullOrWhiteSpace: true nếu chuoiNhap là null, rỗng, hoặc toàn khoảng trắng — bắt đúng case "chưa nhập gì"
            {
                MessageBox.Show("Chưa nhập " + tenTruong);
                return null;
            }

            if (!double.TryParse(chuoiNhap, out double ketQua))
            // TryParse: thử chuyển chuỗi sang double; false nghĩa là chuỗi có nội dung nhưng không phải số hợp lệ (vd: "abc", "1.2.3")
            {
                MessageBox.Show(tenTruong + " không hợp lệ, vui lòng nhập số");
                return null;
            }

            if (ketQua <= 0)
            // chiều dài/chiều rộng của hình chữ nhật không thể bằng 0 hoặc âm
            {
                MessageBox.Show(tenTruong + " phải lớn hơn 0");
                return null;
            }

            return ketQua;
        }
        public static double? SoThuc(string chuoiNhap, string tenTruong)
        {
            if (string.IsNullOrWhiteSpace(chuoiNhap))
            {
                MessageBox.Show("Chưa nhập" + tenTruong);
                return null;
            }
            if (!double.TryParse(chuoiNhap, out double ketQua))
            {
                MessageBox.Show(tenTruong + "Chưa hợp lệ, vui lòng nhập số!");
                return null;
            }
            return ketQua;
        }
        public static string ChuoiKhongRong(string chuoiNhap, string tenTruong)
        {
            if (string.IsNullOrWhiteSpace(chuoiNhap))
            {
                MessageBox.Show("Chưa nhập" + tenTruong);
                return null;
            }
            return chuoiNhap;
        }

        public static int DemSoTu(string chuoiNhap)
        {
            string[] mangCacTu = chuoiNhap.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int soTu = 0;


            foreach (string tu in mangCacTu)
            {
                bool laMotTu = false;
                foreach (char c in tu)
                {
                    if (char.IsLetter(c))
                    {
                        laMotTu = true;
                        break;
                    }
                }
                if (laMotTu) soTu++;
            }
            return soTu;
        }

        public static List<string> ThongKeTanSuatTu(string chuoiNhap)
        {
            string[] MangCatTu = chuoiNhap.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var danhSachTuDaGap = new List<string>();
            var demSoLanXuatHien = new Dictionary<string, int>();


            foreach (string tu in MangCatTu)
            {
                if (demSoLanXuatHien.ContainsKey(tu)) demSoLanXuatHien[tu]++;
                else
                {
                    demSoLanXuatHien[tu] = 1;
                    danhSachTuDaGap.Add(tu);

                }
            }
            var ketQua = new List<string>();
            foreach (string tu in danhSachTuDaGap)
            {
                ketQua.Add(tu + ": " + demSoLanXuatHien[tu] + " lần");
            }
            return ketQua;
        }
        public static double? HeSoKhacKhong(string heSo, string tenTruong)
        {
            double? giaTri = SoThuc(heSo, tenTruong);
            if (giaTri == null) return null;
            if (giaTri == 0)
            {
                MessageBox.Show(tenTruong + "phải khác không");
                return null;
            }
            return giaTri;
        }
        public static string GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta == 0) return "Phương trình vô nghiệm";
            if (delta == 0)
            {
                double x = -b / (2 * a);
                return "Phương trình có nghiệm kép X = " + x;
            }
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return "Phương trình có hai nghiệm X1= " + x1 + " X2 = " + x2;
        }

        public static List<int> TachDayThanhSoNguyen(string chuoiNhap)
        {
            string[] mangCacPhanTuCuaChuoiNhap = chuoiNhap.Split(new char[] { ' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var listSoNguyen = new List<int>(); //chứa các số nguyên
            var listBiLoi = new List<string>(); // chứa các chuỗi không convert sang số nguyên được

            foreach (string phanTu in mangCacPhanTuCuaChuoiNhap)
            {
                if (int.TryParse(phanTu, out int so)) listSoNguyen.Add(so);
                else listBiLoi.Add(phanTu);
            }
            if (listBiLoi.Count > 0) MessageBox.Show("Các giá trị không phải số bị bỏ qua: " + string.Join(", ", listBiLoi));
            return listSoNguyen;
        }

        public static bool TimSoChinhPhuong(int n)
        {
            if (n <= 0) return false;
            int canBacHai = (int)Math.Sqrt(n);
            return canBacHai * canBacHai == n;
        }

        public static long? SoNguyenToiThieu(string chuoiNhap, string tenTruong, long gioiHanDuoi)
        {
            if (string.IsNullOrWhiteSpace(chuoiNhap))
            {
                MessageBox.Show("Chưa nhập " + tenTruong);
                return null;
            }

            if (!long.TryParse(chuoiNhap, out long ketQua))
            {
                MessageBox.Show(tenTruong + " không hợp lệ, vui lòng nhập số nguyên");
                return null;
            }


            if (ketQua < gioiHanDuoi)
            {
                MessageBox.Show(tenTruong + " phải lớn hơn " + gioiHanDuoi);
                return null;
            }
            return ketQua;
        }

        public static string PhanTichThuaSoNguyenTo(long n)
        {
            var thuaSo = new List<long>();
            for (long i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    thuaSo.Add(i);
                    n /= i;
                }
            }
            if (n > 1)
                thuaSo.Add(n);

            return string.Join("*", thuaSo);
        }


        public static void ChuyenMonDaChon(ListBox listChuyenDi, ListBox listDuocNhan)
        {
            var monDaChon = listChuyenDi.SelectedItems.Cast<object>().ToList();

            foreach (var monAn in monDaChon)
            {
                if (!listDuocNhan.Items.Contains(monAn))
                    listDuocNhan.Items.Add(monAn);
                listChuyenDi.Items.Remove(monAn);
            }
        }

        public static void ChuyenTatCa(ListBox lstChuyenDi, ListBox lstDuocNhan)
        {
            var toanBoMon = lstChuyenDi.Items.Cast<object>().ToList();
            foreach (var mon in toanBoMon)
            {
                if (!lstDuocNhan.Items.Contains(mon))
                    lstDuocNhan.Items.Add(mon);
                lstChuyenDi.Items.Remove(mon);
            }
        }

        public static bool CoPhanTuDuocChon(ListBox lst, string tenListBox)
        {
            if (lst.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn món nào trong " + tenListBox);
                return false;
            }
            return true;
        }

        public static bool CoDauCham(string soHienTai)
        {
            return !soHienTai.Contains(".");
        }

        public static double TextToNumber(string chuoiNhap)
        {
            if (string.IsNullOrWhiteSpace(chuoiNhap)) return 0;

            double.TryParse(chuoiNhap, out double so);
            return so;
        }
        public static string DoiDau(string chuoiNhap)
        {
            if (string.IsNullOrWhiteSpace(chuoiNhap)) return chuoiNhap;

            if (chuoiNhap.StartsWith("-")) return chuoiNhap.Substring(1);
            return "-" + chuoiNhap;
        }
        public static bool MayDaMo(bool MayDangMo)
        {
            if (!MayDangMo)
            {
                MessageBox.Show("Vui lòng bật máy (ON/OFF) trước khi sử dụng");
                return false;
            }
            return true;
        }
        public static double? ChiaAnToan(double soA, double soB)
        {
            if (soB == 0)
            {
                MessageBox.Show("Số không thể chia cho 0");
                return null;
            }
            return soA / soB;
        }
        public static string ChuanHoaChuoi(string chuoi)
        // Loại khoảng trắng thừa; dấu câu dính sát từ trước, cách từ sau đúng 1 khoảng trắng
        {
            string ketQua = System.Text.RegularExpressions.Regex.Replace(chuoi.Trim(), @"\s+", " ");
            // \s+ → " ": gom mọi chuỗi khoảng trắng liên tiếp (kể cả tab, xuống dòng) thành đúng 1 dấu cách

            ketQua = System.Text.RegularExpressions.Regex.Replace(ketQua, @"\s+([.,:!?;])", "$1");
            // xóa khoảng trắng đứng TRƯỚC dấu câu — ép dấu câu dính sát từ đứng trước

            ketQua = System.Text.RegularExpressions.Regex.Replace(ketQua, @"([.,:!?;])(?!\s|$)", "$1 ");
            // (?!\s|$): chỉ chèn thêm 1 khoảng trắng SAU dấu câu nếu nó chưa có khoảng trắng và chưa phải cuối chuỗi

            return ketQua;
        }

        public static List<KeyValuePair<string, int>> ThongKeTuDonKhongPhanBiet(string chuoi)
        // thống kê tần số từ đơn, không phân biệt hoa thường, giữ đúng thứ tự từ xuất hiện lần đầu
        {
            string[] token = chuoi.Split(new char[] { ' ', '.', ',', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            // tách theo khoảng trắng VÀ 6 dấu câu — dấu câu không được tính là 1 phần của từ

            var thuTuXuatHien = new List<string>();
            var demSoLan = new Dictionary<string, int>();

            foreach (string t in token)
            {
                string tu = t.ToLower();
                // ToLower(): chuẩn hóa về chữ thường trước khi đếm, để "Con" và "con" tính là cùng 1 từ

                if (demSoLan.ContainsKey(tu))
                    demSoLan[tu]++;
                else
                {
                    demSoLan[tu] = 1;
                    thuTuXuatHien.Add(tu);
                }
            }

            var ketQua = new List<KeyValuePair<string, int>>();

            foreach (string tu in thuTuXuatHien)
                ketQua.Add(new KeyValuePair<string, int>(tu, demSoLan[tu]));

            return ketQua;
        }
        public static bool LaNgaySinhHopLe(string chuoiNhap, out DateTime ketQua)
        {
            return DateTime.TryParseExact(
                chuoiNhap,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out ketQua);
            // TryParseExact: chỉ chấp nhận đúng định dạng "dd/MM/yyyy", không tự suy đoán định dạng khác
            // như TryParse thường làm — đúng yêu cầu "phải nhập theo định dạng dd/mm/yyyy"
        }

        public static bool LaDiemHopLe(string chuoiNhap, out double ketQua)
        {
            return double.TryParse(chuoiNhap, out ketQua);
        }
        public static bool DaChonComboBox(ComboBox cbo, string tenTruong)
        {
            if (cbo.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn " + tenTruong);
                return false;
            }

            return true;
        }


    }

}
