using System;
using System.Collections.Generic;

abstract class PhuongTien
{
    public string TenPhuongTien { get; set; }
    public string LoaiNhienLieu { get; set; }

    public PhuongTien(string tenPhuongTien, string loaiNhienLieu)
    {
        TenPhuongTien = tenPhuongTien;
        LoaiNhienLieu = loaiNhienLieu;
    }

    public abstract void DiChuyen();
}

interface IThongTinThem
{
    double TocDoToiDa();
    double MucTieuThuNhienLieu();
}

class XeHoi : PhuongTien, IThongTinThem
{
    public XeHoi(string tenPhuongTien, string loaiNhienLieu) : base(tenPhuongTien, loaiNhienLieu)
    {
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} dang di chuyen bang dong co {LoaiNhienLieu}");
    }

    public double TocDoToiDa()
    {
        return 200;
    }

    public double MucTieuThuNhienLieu()
    {
        return 8.5;
    }
}

class XeDap : PhuongTien, IThongTinThem
{
    public XeDap(string tenPhuongTien) : base(tenPhuongTien, "Khong co nhien lieu")
    {
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} dang di chuyen bang suc nguoi.");
    }

    public double TocDoToiDa()
    {
        return 25;
    }

    public double MucTieuThuNhienLieu()
    {
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>
        {
            new XeHoi("Xe Hoi", "Xang"),
            new XeDap("Xe Dap")
        };

        foreach (PhuongTien pt in danhSachPhuongTien)
        {
            pt.DiChuyen();
            if (pt is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Toc do toi da: {thongTinThem.TocDoToiDa()} km/h");

                if (pt is XeHoi)
                {
                    Console.WriteLine($"Muc tieu thu nhien lieu: {thongTinThem.MucTieuThuNhienLieu()} lit/100km");
                }
            }
            Console.WriteLine();
        }
    }
}
