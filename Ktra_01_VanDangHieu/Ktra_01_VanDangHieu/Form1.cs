using Ktra_01_VanDangHieu.modes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace Ktra_01_VanDangHieu
{
    public partial class Form1 : Form
    {
        private ShoppingCart cart = new ShoppingCart();
        public Form1()
        {
            InitializeComponent();
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price = decimal.Parse(txtGia.Text);
            int quantity = int.Parse(txtSoluong.Text);

            // Giả sử bạn đã có ảnh sản phẩm trong pictureBox1
            Image image = pictureBox1.Image;

            // Tạo đối tượng sản phẩm mới
            Product product = new Product(name, price, quantity, image);

            // Thêm sản phẩm vào giỏ hàng
            cart.AddProduct(product);

            // Cập nhật giao diện giỏ hàng
            UpdateCartDisplay();
        }

        private void UpdateCartDisplay()
        {
            dataGridViewCart.Rows.Clear();
            foreach (var product in cart.Products)
            {
                dataGridViewCart.Rows.Add(product.Name, product.Price, product.Quantity, product.Price * product.Quantity);
            }

            // Cập nhật tổng giá trị đơn hàng
            lblTongGiaTri.Text = $"Tổng giá trị: {cart.CalculateTotal():C}";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.CurrentRow != null)
            {
                int selectedIndex = dataGridViewCart.CurrentRow.Index;
                cart.RemoveProduct(cart.Products[selectedIndex]);
                UpdateCartDisplay();
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            decimal total = cart.CalculateTotal();
            MessageBox.Show($"Tổng giá trị đơn hàng: {total:C}", "Thanh toán thành công");

            // Xóa giỏ hàng và cập nhật lại giao diện
            cart.ClearCart();
            UpdateCartDisplay();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // Thư mục ban đầu
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Chỉ cho phép chọn file ảnh
                openFileDialog.Title = "Chọn ảnh sản phẩm";

                // Nếu người dùng chọn ảnh và nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh trong PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Tùy chọn hiển thị ảnh
                }
            }
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
