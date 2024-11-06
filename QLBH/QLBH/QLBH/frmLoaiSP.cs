using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
            LoadData();
        }
        KetNoi kn = new KetNoi();

        private void LoadData()
        {
            DataSet ds = kn.LayDuLieu("SELECT * FROM LoaiSanPham");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu.");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO LoaiSanPham (MaLoaiSP, tenSP, motaSP, gia, sl) " +
                   $"VALUES ('{txtMaLoaiSP.Text}', N'{txtTen.Text}', N'{txtMota.Text}', " +
                   $"{txtGia.Text}, {txtSoluong.Text})";
            bool result = kn.ThucThi(query);
            if (result)
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE LoaiSanPham SET MaLoaiSP = '{txtMaLoaiSP.Text}', " +
                    $"tenSP = N'{txtTen.Text}', motaSP = N'{txtMota.Text}', " +
                    $"gia = {txtGia.Text}, sl = {txtSoluong.Text} " +
                    $"WHERE MaLoaiSP = '{txtMaLoaiSP.Text}'";
            bool result = kn.ThucThi(query);
            if (result)
            {
                MessageBox.Show("Sửa sản phẩm thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                string query = $"DELETE FROM LoaiSanPham WHERE ID = '{id}'";
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

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM LoaiSanPham WHERE ID LIKE N'%{txtTimkiem.Text}%'";
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtMaLoaiSP.Text = row.Cells["MaLoaiSP"].Value.ToString();
                txtTen.Text = row.Cells["tenSP"].Value.ToString();
                txtMota.Text = row.Cells["motaSP"].Value.ToString();
                txtGia.Text = row.Cells["gia"].Value.ToString();
                txtSoluong.Text = row.Cells["sl"].Value.ToString();
            }
        }
    }
}
