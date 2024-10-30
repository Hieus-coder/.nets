using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra_01_VanDangHieu.modes
{
    // Lớp Product đại diện cho một sản phẩm
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Image Image { get; set; }

        public Product(string name, decimal price, int quantity, Image image)
        {
            Name = name;
            Price = price;
            Quantity = 0;
            Image = image;
        }
    }

    // Lớp ShoppingCart đại diện cho giỏ hàng
    public class ShoppingCart
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        // Thêm sản phẩm vào giỏ
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Xóa sản phẩm khỏi giỏ
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        // Tính tổng giá trị đơn hàng
        public decimal CalculateTotal()
        {
            return Products.Sum(p => p.Price * p.Quantity);
        }

        // Xóa giỏ hàng
        public void ClearCart()
        {
            Products.Clear();
        }
    }

}
