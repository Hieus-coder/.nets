using System;

public class SinhVien
{
    public string HoTen { get; set; }
    public string MSSV { get; set; }
    public double DiemTrungBinh { get; set; }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap ma so sinh vien: ");
        MSSV = Console.ReadLine();

        Console.Write("Nhap diem trung binh: ");
        string input;
        while (true)
        {
            input = Console.ReadLine();
            input = input.Replace(',', '.');
            if (double.TryParse(input, out double diemTrungBinh))
            {
                DiemTrungBinh = diemTrungBinh;
                break;
            }
            else
            {
                Console.Write("Diem trung binh khong hop le, nhap lai: ");
            }
        }
    }


    public void HienThiThongTin()
    {
        Console.WriteLine($"Ho ten: {HoTen}");
        Console.WriteLine($"MSSV: {MSSV}");
        Console.WriteLine($"Diem trung binh: {DiemTrungBinh:F2}");
    }
}
