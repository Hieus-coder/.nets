using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
            LoadData();
        }
        KetNoi kn = new KetNoi();
        private void LoadData()
        {
            DataSet ds = kn.LayDuLieu("SELECT * FROM DonHang");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu.");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMaLoaiSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text) || string.IsNullOrEmpty(txtMaLoaiSP.Text) ||
            string.IsNullOrEmpty(txtSoluong.Text) || string.IsNullOrEmpty(txtNgayMua.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string query = $"INSERT INTO DonHang (khachhangid, sanphamid, soluong, ngaymua) " +
                           $"VALUES ('{txtMaKhachHang.Text}', '{txtMaLoaiSP.Text}', '{txtSoluong.Text}', '{txtNgayMua.Text}')";

            bool result = kn.ThucThi(query);
            if (result)
            {
                MessageBox.Show("Thêm đơn hàng thành công!");
                LoadData(); // Load lại dữ liệu sau khi thêm
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm đơn hàng.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE DonHang SET khachhangid = '{txtMaKhachHang.Text}', " +
               $"sanphamid = '{txtMaLoaiSP.Text}', " +
               $"soluong = {txtSoluong.Text}, " +
               $"ngaymua = '{txtNgayMua.Text}' " + 
               $"WHERE sanphamid = '{txtMaLoaiSP.Text}'";

            bool result = kn.ThucThi(query);
            if (result)
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                string query = $"DELETE FROM DonHang WHERE id = '{id}'";
                bool result = kn.ThucThi(query);
                if (result)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM DonHang WHERE id LIKE N'%{txtTimkiem.Text}%'";
            DataSet ds = kn.LayDuLieu(query);
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu có một dòng được chọn
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán dữ liệu từ dòng đã chọn vào các TextBox
                txtMaKhachHang.Text = row.Cells["khachhangid"].Value?.ToString() ?? "";
                txtMaLoaiSP.Text = row.Cells["sanphamid"].Value?.ToString() ?? "";
                txtSoluong.Text = row.Cells["soluong"].Value?.ToString() ?? "";
                txtNgayMua.Text = row.Cells["ngaymua"].Value?.ToString() ?? "";
            }
        }

    }
}
