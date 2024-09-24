using System;
using System.Collections.Generic;
using System.Linq;

public class DanhSachSinhVien
{
    private List<SinhVien> danhSachSinhVien;

    public DanhSachSinhVien()
    {
        danhSachSinhVien = new List<SinhVien>();
    }

    public void ThemSinhVien(SinhVien sv)
    {
        danhSachSinhVien.Add(sv);
    }

    public void HienThiDanhSach()
    {
        if (danhSachSinhVien.Count == 0)
        {
            Console.WriteLine("Danh sach sinh vien trong.");
            return;
        }

        Console.WriteLine("Danh sach sinh vien:");
        foreach (var sv in danhSachSinhVien)
        {
            sv.HienThiThongTin();
            Console.WriteLine("----------------------------");
        }
    }

    public void TimSinhVienTheoMSSV(string mssv)
    {
        var sv = danhSachSinhVien.FirstOrDefault(s => s.MSSV == mssv);
        if (sv != null)
        {
            Console.WriteLine("Thong tin sinh vien tim thay:");
            sv.HienThiThongTin();
        }
        else
        {
            Console.WriteLine($"Khong tim thay sinh vien voi MSSV: {mssv}");
        }
    }

    public SinhVien TinhDiemTrungBinhCaoNhat()
    {
        if (danhSachSinhVien.Count == 0) return null;
        return danhSachSinhVien.OrderByDescending(s => s.DiemTrungBinh).FirstOrDefault();
    }
}
