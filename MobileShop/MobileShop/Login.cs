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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from NguoiDung where tendangnhap = '{0}' and matkhau = '{1}'",
            txtTaiKhoan.Text,
            txtMatKhau.Text
    );
            DataSet ds = kn.LayDuLieu(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Main frm = new Main();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
