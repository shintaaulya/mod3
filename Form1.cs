using System.Xml;

namespace mod3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            int num1, num2, num3;
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBox1.Text.Split('+')[0]);
            num2 = Int32.Parse(textBox1.Text.Split('+')[1]);
            int result = num1 + num2;
            if (textBox1.Text.Split('+').Length > 2) {
                num3 = Int32.Parse(textBox1.Text.Split('+')[2]);
                result += num3;
            }
                textBox1.Text = result.ToString();
        }
    }
}
