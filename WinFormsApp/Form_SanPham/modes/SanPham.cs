using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_SanPham.models
{
    public class SanPham
    {
        public SanPham(int maSP, string? tenSP, decimal donGia, string? hinhAnh, string? motangan, string? motachitiet)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            HinhAnh = hinhAnh;
            Motangan = motangan;
            Motachitiet = motachitiet;
        }

        public int MaSP { set; get; }
        public string? TenSP { set; get; }
        public decimal DonGia { set; get; }
        public string? HinhAnh { set; get; }
        public string? Motangan { set; get; }
        public string? Motachitiet { set; get; }
    }
    public class LoaiSanPham
    {
        public string? TenLoai { set; get; }
        public List<SanPham>? danhsachsp { set; get; }

        public override string? ToString()
        {
            return TenLoai;
        }
    }
}
