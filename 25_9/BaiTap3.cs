using System;
using System.Collections.Generic;

public class BaiTap3
{
    public static void Execute()
    {
        Dictionary<string, int> students = new Dictionary<string, int>();

        Console.WriteLine("Nhap ten va diem cua hoc sinh (Nhap 'x' de ket thuc):");
        while (true)
        {
            Console.Write("Nhap ten hoc sinh: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "x")
                break;

            Console.Write("Nhap diem: ");
            string scoreInput = Console.ReadLine();
            if (scoreInput.ToLower() == "x")
                break;

            if (int.TryParse(scoreInput, out int score))
                students[name] = score;
            else
                Console.WriteLine("Vui long nhap diem hop le.");
        }

        Console.WriteLine("Danh sach hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Ten: {student.Key}, Điem: {student.Value}");
        }
    }
}
