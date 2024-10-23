using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Form_SanPham
{
    public partial class Form1 : Form
    {
        private List<SanPham> danhSachSanPham = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = laySanPham().Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Cho phép chọn hàng
            dataGridView1.DataSource = danhSachSanPham; // Cập nhật nguồn dữ liệu

        }
        private void btn_ThemClick_Click(object sender, EventArgs e)
        {

            try
            {
                // Lấy thông tin từ các TextBox và ComboBox
                string maSP = MaSP.Text; // Lấy mã sản phẩm từ TextBox
                string tenSP = TenSP.Text;
                decimal donGia;
                if (!decimal.TryParse(DonGia.Text, out donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ.");
                    return;
                }
                string hinhAnh = HinhAnh.Text;
                string moTaNgan = MoTa.Text;
                string moTaChiTiet = MoTaChiTiet.Text;
                string? loaiSP = LoaiSP.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(loaiSP))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                    return;
                }

                // Tạo đối tượng SanPham và thêm vào danh sách
                SanPham sanPham = new()
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    DonGia = donGia,
                    HinhAnh = hinhAnh,
                    MoTa = moTaNgan,
                    MoTaChiTiet = moTaChiTiet,
                    LoaiSP = loaiSP
                };

                danhSachSanPham.Add(sanPham); // Thêm sản phẩm vào danh sách

                // Insert db

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
                dataGridView1.DataSource = danhSachSanPham; // Cập nhật nguồn dữ liệu

                // query db => set datasource

                // Xóa các TextBox và ComboBox
                MaSP.Clear();
                TenSP.Clear();
                DonGia.Clear();
                HinhAnh.Clear();
                MoTa.Clear();
                MoTaChiTiet.Clear();
                LoaiSP.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
            dataGridView1.DataSource = danhSachSanPham; // Cập nhật nguồn dữ liệu

        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;

        }

        private void btnLamMoi_Click_Click(object sender, EventArgs e)
        {
            MaSP.Clear();
            TenSP.Clear();
            DonGia.Clear();
            HinhAnh.Clear();
            MoTa.Clear();
            MoTaChiTiet.Clear();
            LoaiSP.SelectedIndex = 0;
        }
    }

}