using System;
using System.Collections.Generic;

public class MobilePhone : Product, ISellable
{
    public MobilePhone(string name, decimal price, int stock)
        : base(name, price, stock)
    {
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Mobile Phone: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * percentage / 100;
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Not enough stock to sell {quantity} {Name}(s).");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }

    // Hàm tạo danh sách sản phẩm mặc định
    public static List<MobilePhone> GetDefaultPhones()
    {
        return new List<MobilePhone>
        {
            new MobilePhone("iPhone 14", 1000m, 50),
            new MobilePhone("Samsung Galaxy S23", 900m, 30),
            new MobilePhone("Google Pixel 7", 850m, 40)
        };
    }
}

public class Laptop : Product, ISellable
{
    public Laptop(string name, decimal price, int stock)
        : base(name, price, stock)
    {
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Laptop: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * percentage / 100;
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Not enough stock to sell {quantity} {Name}(s).");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }

    // Hàm tạo danh sách sản phẩm mặc định
    public static List<Laptop> GetDefaultLaptops()
    {
        return new List<Laptop>
        {
            new Laptop("Dell XPS 13", 1500m, 30),
            new Laptop("MacBook Pro 16", 2500m, 20),
            new Laptop("HP Spectre x360", 1400m, 25)
        };
    }
}

public class Accessory : Product, ISellable
{
    public Accessory(string name, decimal price, int stock)
        : base(name, price, stock)
    {
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Accessory: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * percentage / 100;
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Not enough stock to sell {quantity} {Name}(s).");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }

    // Hàm tạo danh sách sản phẩm mặc định
    public static List<Accessory> GetDefaultAccessories()
    {
        return new List<Accessory>
        {
            new Accessory("Wireless Charger", 50m, 100),
            new Accessory("USB-C Cable", 15m, 150),
            new Accessory("Bluetooth Headset", 75m, 70)
        };
    }
}
