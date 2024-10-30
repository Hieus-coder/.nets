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
            dataGridView = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            cbcLoaiSP = new ComboBox();
            txtMotachitiet = new TextBox();
            txtMotangan = new TextBox();
            txtImg = new TextBox();
            txtDongia = new TextBox();
            txtTenSp = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtMasp = new TextBox();
            groupBox3 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnLamMoi = new Button();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
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
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 78);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(772, 569);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
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
            // cbcLoaiSP
            // 
            cbcLoaiSP.FormattingEnabled = true;
            cbcLoaiSP.Location = new Point(134, 380);
            cbcLoaiSP.Name = "cbcLoaiSP";
            cbcLoaiSP.Size = new Size(278, 28);
            cbcLoaiSP.TabIndex = 27;
            cbcLoaiSP.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtMotachitiet
            // 
            txtMotachitiet.Location = new Point(135, 259);
            txtMotachitiet.Multiline = true;
            txtMotachitiet.Name = "txtMotachitiet";
            txtMotachitiet.Size = new Size(278, 100);
            txtMotachitiet.TabIndex = 26;
            // 
            // txtMotangan
            // 
            txtMotangan.Location = new Point(134, 217);
            txtMotangan.Name = "txtMotangan";
            txtMotangan.Size = new Size(278, 27);
            txtMotangan.TabIndex = 25;
            // 
            // txtImg
            // 
            txtImg.Location = new Point(134, 176);
            txtImg.Name = "txtImg";
            txtImg.Size = new Size(278, 27);
            txtImg.TabIndex = 24;
            // 
            // txtDongia
            // 
            txtDongia.Location = new Point(135, 134);
            txtDongia.Name = "txtDongia";
            txtDongia.Size = new Size(277, 27);
            txtDongia.TabIndex = 23;
            // 
            // txtTenSp
            // 
            txtTenSp.Location = new Point(134, 92);
            txtTenSp.Name = "txtTenSp";
            txtTenSp.Size = new Size(278, 27);
            txtTenSp.TabIndex = 22;
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
            // txtMasp
            // 
            txtMasp.Location = new Point(134, 46);
            txtMasp.Name = "txtMasp";
            txtMasp.Size = new Size(125, 27);
            txtMasp.TabIndex = 14;
            txtMasp.TextChanged += MaSP_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnLamMoi);
            groupBox3.Location = new Point(3, 575);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(445, 90);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(327, 43);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(227, 43);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(127, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btn_ThemClick_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(24, 43);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbcLoaiSP);
            groupBox1.Controls.Add(txtTenSp);
            groupBox1.Controls.Add(txtMotachitiet);
            groupBox1.Controls.Add(txtMasp);
            groupBox1.Controls.Add(txtMotangan);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtImg);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtDongia);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnLamMoi;
        private ComboBox cbcLoaiSP;
        private TextBox txtMotachitiet;
        private TextBox txtMotangan;
        private TextBox txtImg;
        private TextBox txtDongia;
        private TextBox txtTenSp;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtMasp;
        private GroupBox groupBox1;
        private DataGridView dataGridView;
    }
}
