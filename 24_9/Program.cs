using System;

class Program
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            Console.Write("Nhap so luong sinh vien (>=3): ");

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Vui long nhap lai so luong sinh vien (>=3): ");
            }

            if (n < 3)
            {
                Console.WriteLine("Vui long nhap lai.");
            }

        } while (n < 3);

        Console.WriteLine($"Bạn đã nhập số lượng sinh viên là: {n}");


        DanhSachSinhVien ds = new DanhSachSinhVien();


        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Nhap thong tin cho sinh vien {i + 1}:");
            SinhVien sv = new SinhVien();
            sv.NhapThongTin();
            ds.ThemSinhVien(sv);
            Console.WriteLine("----------------------------");
        }

        ds.HienThiDanhSach();

        SinhVien svCaoNhat = ds.TinhDiemTrungBinhCaoNhat();
        if (svCaoNhat != null)
        {
            Console.WriteLine("Sinh vien co diem trung binh cao nhat:");
            svCaoNhat.HienThiThongTin();
        }

        Console.Write("Nhap MSSV can tim: ");
        string mssvTimKiem = Console.ReadLine();
        ds.TimSinhVienTheoMSSV(mssvTimKiem);

        Console.ReadLine();
    }
}
