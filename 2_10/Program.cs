using System;

class Program
{
    static void Main(string[] args)
    {
        var phones = MobilePhone.GetDefaultPhones();
        var laptops = Laptop.GetDefaultLaptops();
        var accessories = Accessory.GetDefaultAccessories();

        Console.WriteLine("\nDanh sach san pham:");

        Console.WriteLine("Available Mobile Phones:");
        foreach (var phone in phones)
        {
            phone.DisplayProductInfo();
        }

        Console.WriteLine("\nAvailable Laptops:");
        foreach (var laptop in laptops)
        {
            laptop.DisplayProductInfo();
        }

        Console.WriteLine("\nAvailable Accessories:");
        foreach (var accessory in accessories)
        {
            accessory.DisplayProductInfo();
        }

        Console.WriteLine("\nThuc hien ban san pham:");
        phones[0].Sell(5);
        laptops[1].Sell(2); 
        accessories[0].Sell(10);

        Console.WriteLine("\nHang hoa con lai sau khi ban:");
        phones[0].DisplayProductInfo();
        laptops[1].DisplayProductInfo();
        accessories[0].DisplayProductInfo();

        phones[1].ApplyDiscount(10);
        laptops[0].ApplyDiscount(15);
        accessories[2].ApplyDiscount(5);

        Console.WriteLine("\nThong tin hang sau khi ap dung giam gia:");
        phones[1].DisplayProductInfo();
        laptops[0].DisplayProductInfo();
        accessories[2].DisplayProductInfo();
    }
}
