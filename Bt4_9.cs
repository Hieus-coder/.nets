using System;

class Bt4_9
{
    static void nhap(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan tu cua mang: ");
            Console.WriteLine("a[" + i + "]= ");
            a[i] = int.Parse(Console.ReadLine());
        }
    }
    static void xuat(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
            Console.WriteLine(a[i] + " ");
    }

    //Bai 1
    static void tong(int[] a, int n)
    {
        int tong = 0;
        for (int i = 0; i < n; i++)
            tong += a[i];
        Console.WriteLine("Tong tat ca cac phan tu trong mang: " + tong);
    }

    //Bai 2
    static void Demkitu(string input)
    {
        int dem = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetterOrDigit(input[i]))
                dem++;
        }
        Console.WriteLine("Tong so ki tu la: " + dem);
    }

    //Bai 3
    static void seach_max(int[] a, int n)
    {
        int max = a[0];
        for (int i = 0; i < n; i++)
        {
            if (max <= a[i])
                max = a[i];
        }
        Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
    }

    //Bai 4
    static void reverse(string input)
    {
        char[] c = input.ToCharArray();
        Array.Reverse(c);
        string d = new string(c);
        Console.WriteLine("Mang sau khi dao nguoc: " + d);
    }

    //Bai 5
    static void palinpdrome(int[] a, int n)
    {
        int dem = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (a[i] != a[n - i - 1])
            {
                Console.WriteLine("Mang tren khong phai mang doi xung");
                dem++;
                break;
            }
        }
        if (dem == 0)
            Console.WriteLine("Mang tren la mang doi xung");
    }

    //Bai 6
    static int dem(string input, char x)
    {
        int dem = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == x)
            {
                dem++;
            }
        }
        return dem;
    }
    static void Main()
    {
        Console.WriteLine("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        nhap(a, n);
        Console.WriteLine("Danh sach phan tu: ");
        xuat(a, n);
        tong(a, n);

        Console.Write("Nhap chuoi ki tu: ");
        string input = Console.ReadLine();
        Demkitu(input);

        seach_max(a, n);
        reverse(input);

        palinpdrome(a, n);


        Console.WriteLine("Nhap ky tu can tim: ");
        char x = char.Parse(Console.ReadLine());
        Console.WriteLine("Trong chuoi co " + dem(input, x) + " ky tu");
    }
}