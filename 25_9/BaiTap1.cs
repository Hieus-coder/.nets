using System;
using System.Collections;

public class BaiTap1
{
    public static void Execute()
    {
        ArrayList numbers = new ArrayList();

        Console.WriteLine("Nhap vao cac so nguyen (Nhap 'x' de ket thuc):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "x")
                break;

            if (int.TryParse(input, out int number))
                numbers.Add(number);
            else
                Console.WriteLine("Vui long nhap so nguyen hop le.");
        }

        numbers.Sort();

        Console.WriteLine("Danh sach cac so nguyen da nhap theo thu tu tang dan:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
