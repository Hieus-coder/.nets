namespace MobileShop
{
    partial class DonHang
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
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNgayMua = new TextBox();
            txtSoluong = new TextBox();
            txtTimkiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimkiem = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            txtMaLoaiSP = new TextBox();
            txtMaKhachHang = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(184, 55);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(205, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 63);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 113);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 222);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Ngày mua";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 288);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 5;
            label5.Text = "Số lượng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(581, 121);
            label6.Name = "label6";
            label6.Size = new Size(236, 29);
            label6.TabIndex = 6;
            label6.Text = "Tìm kiếm đơn hàng";
            label6.Click += label6_Click;
            // 
            // txtNgayMua
            // 
            txtNgayMua.Location = new Point(184, 215);
            txtNgayMua.Margin = new Padding(3, 4, 3, 4);
            txtNgayMua.Name = "txtNgayMua";
            txtNgayMua.Size = new Size(205, 27);
            txtNgayMua.TabIndex = 8;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(184, 281);
            txtSoluong.Margin = new Padding(3, 4, 3, 4);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(205, 27);
            txtSoluong.TabIndex = 10;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(530, 229);
            txtTimkiem.Margin = new Padding(3, 4, 3, 4);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(258, 27);
            txtTimkiem.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(465, 34);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 49);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(604, 34);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(101, 49);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(748, 34);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 49);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(794, 216);
            btnTimkiem.Margin = new Padding(3, 4, 3, 4);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(114, 46);
            btnTimkiem.TabIndex = 15;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 385);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(842, 289);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 164);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 17;
            label7.Text = "Mã sản phẩm:";
            // 
            // txtMaLoaiSP
            // 
            txtMaLoaiSP.Location = new Point(184, 164);
            txtMaLoaiSP.Margin = new Padding(3, 4, 3, 4);
            txtMaLoaiSP.Name = "txtMaLoaiSP";
            txtMaLoaiSP.Size = new Size(205, 27);
            txtMaLoaiSP.TabIndex = 18;
            txtMaLoaiSP.TextChanged += txtMaLoaiSP_TextChanged;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(184, 106);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(205, 27);
            txtMaKhachHang.TabIndex = 19;
            // 
            // DonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 689);
            Controls.Add(txtMaKhachHang);
            Controls.Add(txtMaLoaiSP);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(btnTimkiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimkiem);
            Controls.Add(txtSoluong);
            Controls.Add(txtNgayMua);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DonHang";
            Text = "frmLoaiSP";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNgayMua;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private TextBox txtMaKhachHang;
    }
}