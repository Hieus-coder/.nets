﻿using Ktra_01_VanDangHieu.modes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ktra_01_VanDangHieu
{
    public partial class Form1 : Form
    {
        private ShoppingCart cart = new ShoppingCart();
        public Form1()
        {
            InitializeComponent();
            LoadAvailableProducts();
        }
        private void LoadAvailableProducts()
        {
            // Giả sử danh sách sản phẩm có sẵn
            var availableProducts = new List<Product>
            {
                new Product("Sản phẩm A", 1000, 1),
                new Product("Sản phẩm B", 2000, 1),
                new Product("Sản phẩm C", 3000, 1)
            };

            foreach (var product in availableProducts)
            {
                // Thêm sản phẩm vào dataGridView1
                dataGridView1.Rows.Add(product.Name, product.Price);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Khi người dùng chọn một dòng trong dataGridView1
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                string name = selectedRow.Cells[0].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells[1].Value);

                // Lấy ảnh sản phẩm dựa trên tên sản phẩm

                // Hiển thị ảnh của sản phẩm trong PictureBox
            }

        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ dòng đã chọn trong dataGridView1
            if (dataGridView1.CurrentRow != null)
            {
                var selectedRow = dataGridView1.CurrentRow;
                string name = selectedRow.Cells[0].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells[1].Value);
                int quantity = 1; // Đặt số lượng mặc định là 1 hoặc bạn có thể thêm TextBox cho số lượng

                // Lấy ảnh sản phẩm

                // Tạo đối tượng sản phẩm từ thông tin trong dataGridView1
                Product product = new Product(name, price, quantity);

  
              // Thêm sản phẩm vào giỏ hàng
                cart.AddProduct(product);
                // Cập nhật giao diện giỏ hàng
                UpdateCartDisplay();
            }
        }

        private void UpdateCartDisplay()
        {
            dataGridViewCart.Rows.Clear();
            foreach (var product in cart.Products)
            {
                dataGridViewCart.Rows.Add(product.Name, product.Price, product.Quantity, product.Price * product.Quantity);
            }

            lblTongGiaTri.Text = $"Tổng giá trị: {cart.CalculateTotal():C}";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.CurrentRow != null)
            {
                if (dataGridViewCart.CurrentRow != null)
                {
                    int selectedIndex = dataGridViewCart.CurrentRow.Index;
                    cart.RemoveProduct(cart.Products[selectedIndex]);
                    UpdateCartDisplay();
                }
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            decimal total = cart.CalculateTotal();
            MessageBox.Show($"Tổng giá trị đơn hàng: {total:C}", "Thanh toán thành công");

            cart.ClearCart();
            UpdateCartDisplay();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTongGiaTri_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCart_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
