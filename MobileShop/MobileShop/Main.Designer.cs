namespace MobileShop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            SanPhamtrip = new ToolStripMenuItem();
            KhachHangTrip = new ToolStripMenuItem();
            DonHangTrip = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { SanPhamtrip, KhachHangTrip, DonHangTrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Danh mục sản phẩm";
            // 
            // SanPhamtrip
            // 
            SanPhamtrip.Name = "SanPhamtrip";
            SanPhamtrip.Size = new Size(89, 24);
            SanPhamtrip.Text = "Sản phẩm";
            SanPhamtrip.Click += SanPhamtrip_Click;
            // 
            // KhachHangTrip
            // 
            KhachHangTrip.Name = "KhachHangTrip";
            KhachHangTrip.Size = new Size(100, 24);
            KhachHangTrip.Text = "Khách hàng";
            KhachHangTrip.Click += KhachHangTrip_Click;
            // 
            // DonHangTrip
            // 
            DonHangTrip.Name = "DonHangTrip";
            DonHangTrip.Size = new Size(88, 24);
            DonHangTrip.Text = "Đơn hàng";
            DonHangTrip.Click += DonHangTrip_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem SanPhamtrip;
        private ToolStripMenuItem KhachHangTrip;
        private ToolStripMenuItem DonHangTrip;
    }
}