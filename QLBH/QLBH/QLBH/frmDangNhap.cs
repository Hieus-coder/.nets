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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from Nguoidung where TaiKhoan = '{0}' and MatKhau = '{1}'",
                txtTaiKhoan.Text,
                txtMatKhau.Text
            );
            DataSet ds = kn.LayDuLieu(query);
            if(ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmHeThong frm = new frmHeThong();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
