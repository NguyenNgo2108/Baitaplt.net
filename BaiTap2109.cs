using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class BaiTap2109
    {
        public static void Main(string[] args)
        {
            DanhSachSinhVien danhSach = new DanhSachSinhVien();
            int soLuongSinhVien;

            Console.Write("Nhap so luong sinh vien muon them: ");
            soLuongSinhVien = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < soLuongSinhVien; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}:");
                danhSach.ThemSinhVien();
            }

            // Hiển thị danh sách sinh viên
            danhSach.HienThiDanhSach();

            // Tìm sinh viên có điểm trung bình cao nhất
            var svCaoNhat = danhSach.TinhDiemTrungBinhCaoNhat();
            if (svCaoNhat != null)
            {
                Console.WriteLine("Sinh vien co diem tb cao nhat:");
                svCaoNhat.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("Chua co sinh vien nao trong danh sach.");
            }

            // Tìm kiếm theo MSSV
            Console.Write("Nhap MSSV can tim: ");
            string mssvTimKiem = Console.ReadLine();
            var svTimKiem = danhSach.TimSinhVienTheoMSSV(mssvTimKiem);
            if (svTimKiem != null)
            {
                Console.WriteLine("Thong tin sinh viên tim thay:");
                svTimKiem.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien voi MSSV nay.");
            }
        }

        class SinhVien
        {
            public string HoTen { get; set; }
            public string MSSV { get; set; }
            public double DiemTrungBinh { get; set; }

            public void NhapThongTin()
            {
                Console.Write("Nhap ho va ten: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhap ma so sinh vien: ");
                MSSV = Console.ReadLine();
                Console.Write("Nhap diem tb: ");
                DiemTrungBinh = Convert.ToDouble(Console.ReadLine());
            }

            public void HienThiThongTin()
            {
                Console.WriteLine($"Ho va ten: {HoTen}, MSSV: {MSSV}, Diem trung binh: {DiemTrungBinh}");
            }
        }

        class DanhSachSinhVien
        {
            private List<SinhVien> sinhViens = new List<SinhVien>();

            public void ThemSinhVien()
            {
                SinhVien sv = new SinhVien();
                sv.NhapThongTin();
                sinhViens.Add(sv);
            }

            public void HienThiDanhSach()
            {
                Console.WriteLine("Danh sách sinh viên:");
                foreach (var sv in sinhViens)
                {
                    sv.HienThiThongTin();
                }
            }

            public SinhVien TimSinhVienTheoMSSV(string mssv)
            {
                foreach (var sv in sinhViens)
                {
                    if (sv.MSSV.Equals(mssv, StringComparison.OrdinalIgnoreCase))
                    {
                        return sv;
                    }
                }
                return null;
            }

            public SinhVien TinhDiemTrungBinhCaoNhat()
            {
                if (sinhViens.Count == 0) return null;

                SinhVien svCaoNhat = sinhViens[0];
                foreach (var sv in sinhViens)
                {
                    if (sv.DiemTrungBinh > svCaoNhat.DiemTrungBinh)
                    {
                        svCaoNhat = sv;
                    }
                }
                return svCaoNhat;
            }
        }
    }
}
