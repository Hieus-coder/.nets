using System;
public class baitap
{
    public void max() 
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Hien thi mang: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();

        Console.ReadKey();
    }
    public void radom() 
    {
        Random random = new Random();

        int randomNumber = random.Next(1, 7);

        Console.Write("Nhập vào số bạn đoán (từ 1 đến 6): ");
        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess == randomNumber)
        {
            Console.WriteLine("Chúc mừng! Bạn đã đoán đúng!");
        }
        else
        {
            Console.WriteLine("Bạn đã thua!");
            Console.WriteLine("Số của tôi là " + randomNumber);
        }
    }
}
