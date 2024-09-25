using System;
using System.Collections;

public class BaiTap2
{
    public static void Execute()
    {
        Hashtable people = new Hashtable();

        Console.WriteLine("Nhap ten tuoi (Nhap 'x' de ket thuc):");
        while (true)
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "x")
                break;

            Console.Write("Nhap tuoi: ");
            string ageInput = Console.ReadLine();
            if (ageInput.ToLower() == "x")
                break;

            if (int.TryParse(ageInput, out int age))
                people[name] = age;
            else
                Console.WriteLine("Vui long nhap tuoi hop le.");
        }

        Console.WriteLine("Danh sach ten tuoi da nhap:");
        foreach (DictionaryEntry entry in people)
        {
            Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
        }
    }
}
