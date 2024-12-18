﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void SanPhamtrip_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MdiParent = this;
            sp.Show();
        }

        private void KhachHangTrip_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void DonHangTrip_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang();
            dh.MdiParent = this;
            dh.Show();
        }
    }
}
