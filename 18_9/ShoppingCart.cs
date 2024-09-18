using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; } 
    public string Description { get; set; }
    public int Quantity { get; set; }

    public Product(string name, decimal price, string description, int quantity)
    {
        Name = name;
        Price = price;
        Description = description;
        Quantity = quantity;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ten san pham: {Name}, Gia: {Price:C}, Mo ta: {Description}, So luong: {Quantity}");
    }
}

public class Electronic : Product
{
    public int WarrantyMonths { get; set; }

    public Electronic(string name, decimal price, string description, int quantity, int warrantyMonths)
        : base(name, price, description, quantity)
    {
        WarrantyMonths = warrantyMonths;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Bao hanh: {WarrantyMonths} thang");
    }
}

public class Clothing : Product
{
    public string Size { get; set; }
    public string Color { get; set; }

    public Clothing(string name, decimal price, string description, int quantity, string size, string color)
        : base(name, price, description, quantity)
    {
        Size = size;
        Color = color;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Kich thuoc: {Size}, Mau sac: {Color}");
    }
}

public class Food : Product
{
    public DateTime ExpirationDate { get; set; }

    public Food(string name, decimal price, string description, int quantity, DateTime expirationDate)
        : base(name, price, description, quantity)
    {
        ExpirationDate = expirationDate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Ngay het han: {ExpirationDate:dd/MM/yyyy}");
    }
}

public class ShoppingCart
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        _products.Add(product);
        Console.WriteLine($"Da them san pham {product.Name} vao gio hang.");
    }

    public void RemoveProduct(Product product)
    {
        _products.Remove(product);
        Console.WriteLine($"Da xoa san pham {product.Name} khoi gio hang.");
    }

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.Price;
        }
        return total;
    }
    public void DisplayCart()
    {
        Console.WriteLine("San pham trong gio hang:");
        foreach (var product in _products)
        {
            product.DisplayInfo();
            Console.WriteLine("----------------------");
        }
        Console.WriteLine($"Tong gia tri don hang: {CalculateTotalPrice():C}");
    }
}

