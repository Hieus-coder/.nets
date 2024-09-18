public class Program
{
    public static void Main(string[] args)
    {
        Product laptop = new Electronic("Laptop", 15000000, "Laptop Dell XPS 13", 5, 24);
        Product shirt = new Clothing("Ao so mi", 500000, "Ao so mi nam", 10, "L", "Trang");
        Product apple = new Food("Tao", 20000, "Tao nhap khau", 50, new DateTime(2024, 12, 31));

        ShoppingCart cart = new ShoppingCart();

        cart.AddProduct(laptop);
        cart.AddProduct(shirt);
        cart.AddProduct(apple);


        cart.DisplayCart();

        
        cart.RemoveProduct(shirt);

        cart.DisplayCart();
    }
}
