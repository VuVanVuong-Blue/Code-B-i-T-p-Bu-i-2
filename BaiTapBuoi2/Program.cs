using System;
using System.Collections.Generic;
using System.Linq;

class SinhVien
{
    public int MaSo { get; set; }
    public string TenSV { get; set; }
    public int Tuoi { get; set; }

    // Constructor
    public SinhVien(int maSo, string tenSV, int tuoi)
    {
        MaSo = maSo;
        TenSV = tenSV;
        Tuoi = tuoi;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Mã số: {MaSo}, Tên: {TenSV}, Tuổi: {Tuoi}");
    }
}

namespace BaiTapBuoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách sinh viên
            List<SinhVien> danhSachSV = new List<SinhVien>
            {
                new SinhVien(1, "An", 15),
                new SinhVien(2, "Bình", 18),
                new SinhVien(3, "Cường", 17),
                new SinhVien(4, "Dung", 14),
                new SinhVien(5, "Anh", 16)
            };

            // a. In danh sách toàn bộ danh sách học sinh
            Console.WriteLine("Danh sach toan bo sinh vien:");
            foreach (var sv in danhSachSV)
            {
                sv.HienThiThongTin();
            }

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var tuoiTu15Den18 = danhSachSV.Where(sv => sv.Tuoi >= 15 && sv.Tuoi <= 18).ToList();
            Console.WriteLine("\nSinh vien co tuoi tu 15 đen 18:");
            foreach (var sv in tuoiTu15Den18)
            {
                sv.HienThiThongTin();
            }

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var tenBatDauBangA = danhSachSV.Where(sv => sv.TenSV.StartsWith("A")).ToList();
            Console.WriteLine("\nSinh vien co ten bet đau bang chu 'A':");
            foreach (var sv in tenBatDauBangA)
            {
                sv.HienThiThongTin();
            }

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            int tongTuoi = danhSachSV.Sum(sv => sv.Tuoi);
            Console.WriteLine($"\nTong tuoi cua all sinh vien: {tongTuoi}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var tuoiLonNhat = danhSachSV.OrderByDescending(sv => sv.Tuoi).FirstOrDefault();
            Console.WriteLine("\nSinh vien co tuoi MAX:");
            tuoiLonNhat?.HienThiThongTin();

            // f. Sắp xếp danh sách theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var sapXepTheoTuoi = danhSachSV.OrderBy(sv => sv.Tuoi).ToList();
            Console.WriteLine("\nDanh sach sinh vien sau khi sap xap theo tuoi tang dan:");
            foreach (var sv in sapXepTheoTuoi)
            {
                sv.HienThiThongTin();
            }
        }
    }
}
