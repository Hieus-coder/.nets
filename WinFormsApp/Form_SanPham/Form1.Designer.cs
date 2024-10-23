namespace Form_SanPham
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            LoaiSP = new ComboBox();
            MoTaChiTiet = new TextBox();
            MoTa = new TextBox();
            HinhAnh = new TextBox();
            DonGia = new TextBox();
            TenSP = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            MaSP = new TextBox();
            groupBox3 = new GroupBox();
            btnXoa_Click = new Button();
            btnSua_Click = new Button();
            btn_ThemClick = new Button();
            btnLamMoi_Click = new Button();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(454, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(778, 653);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(772, 569);
            dataGridView1.TabIndex = 4;
            dataGridView1.AllowUserToAddRowsChanged += dataGridView1_AllowUserToAddRowsChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(678, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            label1.Click += label1_Click;
            // 
            // LoaiSP
            // 
            LoaiSP.FormattingEnabled = true;
            LoaiSP.Items.AddRange(new object[] { "Trứng gà ", "Trứng Vịt", "Trứng ngỗng", "Trứng đà điểu" });
            LoaiSP.Location = new Point(134, 380);
            LoaiSP.Name = "LoaiSP";
            LoaiSP.Size = new Size(278, 28);
            LoaiSP.TabIndex = 27;
            LoaiSP.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // MoTaChiTiet
            // 
            MoTaChiTiet.Location = new Point(134, 262);
            MoTaChiTiet.Multiline = true;
            MoTaChiTiet.Name = "MoTaChiTiet";
            MoTaChiTiet.Size = new Size(278, 100);
            MoTaChiTiet.TabIndex = 26;
            // 
            // MoTa
            // 
            MoTa.Location = new Point(134, 217);
            MoTa.Name = "MoTa";
            MoTa.Size = new Size(278, 27);
            MoTa.TabIndex = 25;
            // 
            // HinhAnh
            // 
            HinhAnh.Location = new Point(134, 176);
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Size = new Size(278, 27);
            HinhAnh.TabIndex = 24;
            // 
            // DonGia
            // 
            DonGia.Location = new Point(135, 134);
            DonGia.Name = "DonGia";
            DonGia.Size = new Size(277, 27);
            DonGia.TabIndex = 23;
            // 
            // TenSP
            // 
            TenSP.Location = new Point(134, 92);
            TenSP.Name = "TenSP";
            TenSP.Size = new Size(278, 27);
            TenSP.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 383);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 21;
            label9.Text = "Loại SP:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 262);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 20;
            label10.Text = "Mô tả chi tiết:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 220);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 19;
            label11.Text = "Mô tả ngắn:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 179);
            label12.Name = "label12";
            label12.Size = new Size(71, 20);
            label12.TabIndex = 18;
            label12.Text = "Hình ảnh:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 137);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 17;
            label13.Text = "Đơn giá:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 95);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 16;
            label14.Text = "Tên SP:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 49);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 15;
            label15.Text = "Mã SP:";
            // 
            // MaSP
            // 
            MaSP.Location = new Point(134, 46);
            MaSP.Name = "MaSP";
            MaSP.Size = new Size(125, 27);
            MaSP.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoa_Click);
            groupBox3.Controls.Add(btnSua_Click);
            groupBox3.Controls.Add(btn_ThemClick);
            groupBox3.Controls.Add(btnLamMoi_Click);
            groupBox3.Location = new Point(3, 575);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(445, 90);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnXoa_Click
            // 
            btnXoa_Click.Location = new Point(327, 43);
            btnXoa_Click.Name = "btnXoa_Click";
            btnXoa_Click.Size = new Size(94, 29);
            btnXoa_Click.TabIndex = 3;
            btnXoa_Click.Text = "Xóa";
            btnXoa_Click.UseVisualStyleBackColor = true;
            // 
            // btnSua_Click
            // 
            btnSua_Click.Location = new Point(227, 43);
            btnSua_Click.Name = "btnSua_Click";
            btnSua_Click.Size = new Size(94, 29);
            btnSua_Click.TabIndex = 2;
            btnSua_Click.Text = "Sửa";
            btnSua_Click.UseVisualStyleBackColor = true;
            btnSua_Click.Click += btnSua_Click_Click;
            // 
            // btn_ThemClick
            // 
            btn_ThemClick.Location = new Point(127, 43);
            btn_ThemClick.Name = "btn_ThemClick";
            btn_ThemClick.Size = new Size(94, 29);
            btn_ThemClick.TabIndex = 1;
            btn_ThemClick.Text = "Thêm";
            btn_ThemClick.UseVisualStyleBackColor = true;
            btn_ThemClick.Click += btn_ThemClick_Click;
            // 
            // btnLamMoi_Click
            // 
            btnLamMoi_Click.Location = new Point(24, 43);
            btnLamMoi_Click.Name = "btnLamMoi_Click";
            btnLamMoi_Click.Size = new Size(94, 29);
            btnLamMoi_Click.TabIndex = 0;
            btnLamMoi_Click.Text = "Làm mới";
            btnLamMoi_Click.UseVisualStyleBackColor = true;
            btnLamMoi_Click.Click += btnLamMoi_Click_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LoaiSP);
            groupBox1.Controls.Add(TenSP);
            groupBox1.Controls.Add(MoTaChiTiet);
            groupBox1.Controls.Add(MaSP);
            groupBox1.Controls.Add(MoTa);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(HinhAnh);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(DonGia);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 557);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 677);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnXoa_Click;
        private Button btnSua_Click;
        private Button btn_ThemClick;
        private Button btnLamMoi_Click;
        private ComboBox LoaiSP;
        private TextBox MoTaChiTiet;
        private TextBox MoTa;
        private TextBox HinhAnh;
        private TextBox DonGia;
        private TextBox TenSP;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox MaSP;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}
