namespace Ktra_01_VanDangHieu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtGia = new TextBox();
            label3 = new Label();
            txtSoluong = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThanhtoan = new Button();
            dataGridViewCart = new DataGridView();
            btnChonAnh = new Button();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            lblTongGiaTri = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 81);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên sản phẩm:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 153);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 2;
            label2.Text = "Giá:";
            // 
            // txtName
            // 
            txtName.Location = new Point(359, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 27);
            txtName.TabIndex = 3;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(254, 150);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(246, 27);
            txtGia.TabIndex = 4;
            txtGia.TextChanged += txtGia_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(506, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Số lượng:";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(584, 150);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(125, 27);
            txtSoluong.TabIndex = 6;
            txtSoluong.TextChanged += textSoluong_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(86, 477);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(290, 477);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThanhtoan
            // 
            btnThanhtoan.Location = new Point(483, 477);
            btnThanhtoan.Name = "btnThanhtoan";
            btnThanhtoan.Size = new Size(131, 29);
            btnThanhtoan.TabIndex = 9;
            btnThanhtoan.Text = "Thanh toán";
            btnThanhtoan.UseVisualStyleBackColor = true;
            btnThanhtoan.Click += btnThanhtoan_Click;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCart.Location = new Point(95, 257);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(554, 190);
            dataGridViewCart.TabIndex = 10;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(40, 200);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 13;
            btnChonAnh.Text = "Tải ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng giá trị";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Giá";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 216);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 12;
            label4.Text = "Tổng:";
            // 
            // lblTongGiaTri
            // 
            lblTongGiaTri.Location = new Point(511, 213);
            lblTongGiaTri.Name = "lblTongGiaTri";
            lblTongGiaTri.Size = new Size(198, 27);
            lblTongGiaTri.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 564);
            Controls.Add(btnChonAnh);
            Controls.Add(label4);
            Controls.Add(lblTongGiaTri);
            Controls.Add(dataGridViewCart);
            Controls.Add(btnThanhtoan);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtSoluong);
            Controls.Add(label3);
            Controls.Add(txtGia);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtGia;
        private Label label3;
        private TextBox txtSoluong;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThanhtoan;
        private DataGridView dataGridViewCart;
        private Button btnChonAnh;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label4;
        private TextBox lblTongGiaTri;
    }
}
