namespace Calculator1
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

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if ((txtKQ.Text == "0") || (operationPressed))
                txtKQ.Clear();

            operationPressed = false;
            txtKQ.Text += "0";
        }

        private void buttoncong_Click(object sender, EventArgs e)
        {
            operation = "+";
            value = double.Parse(txtKQ.Text);
            operationPressed = true;
        }

        private void buttontru_Click(object sender, EventArgs e)
        {
            operation = "-";
            value = double.Parse(txtKQ.Text);
            operationPressed = true;
        }

        private void buttonnhan_Click(object sender, EventArgs e)
        {
            operation = "*";
            value = double.Parse(txtKQ.Text);
            operationPressed = true;
        }

        private void buttonchia_Click(object sender, EventArgs e)
        {
            operation = "/";
            value = double.Parse(txtKQ.Text);
            operationPressed = true;
        }

        private void buttonKQ_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtKQ.Text = (value + double.Parse(txtKQ.Text)).ToString();
                    break;
                case "-":
                    txtKQ.Text = (value - double.Parse(txtKQ.Text)).ToString();
                    break;
                case "*":
                    txtKQ.Text = (value * double.Parse(txtKQ.Text)).ToString();
                    break;
                case "/":
                    txtKQ.Text = (value / double.Parse(txtKQ.Text)).ToString();
                    break;
            }
            operationPressed = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "0";
            value = 0;
            operation = "";
            operationPressed = false;
        }
    }
}
