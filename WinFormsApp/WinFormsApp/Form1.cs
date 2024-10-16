using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtKQ.Text = (value + Double.Parse(txtKQ.Text)).ToString();
                    break;
                case "-":
                    txtKQ.Text = (value - Double.Parse(txtKQ.Text)).ToString();
                    break;
                case "*":
                    txtKQ.Text = (value * Double.Parse(txtKQ.Text)).ToString();
                    break;
                case "/":
                    txtKQ.Text = (value / Double.Parse(txtKQ.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || operationPressed)
                txtKQ.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtKQ.Text += button.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "0";
            value = 0;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;  // Xác định nút phép tính nào được bấm
            operation = button.Text;         // Lưu phép tính (+, -, *, /)
            value = Double.Parse(txtKQ.Text); // Lưu giá trị hiện tại
            operationPressed = true;         // Đánh dấu là vừa bấm phép tính
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(txtKQ.Text);
            operationPressed = true;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(txtKQ.Text);
            operationPressed = true;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(txtKQ.Text);
            operationPressed = true;
        }
    }
}