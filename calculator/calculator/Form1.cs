namespace calculator
{
    public partial class Form1 : Form
    {
        string operate= "";
        decimal calculation = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void getvalue()
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "/" && textBox1.Text != "-" && textBox1.Text != "*")
            {
                calculation = Convert.ToDecimal(textBox1.Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
        
            getvalue();
            operate = "+";
            textBox1.Text = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            getvalue();
            operate = "/";
            textBox1.Text = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal firstnum = calculation;
            decimal secondnum= Convert.ToDecimal(textBox1.Text);
            switch (operate)
            {
                case "+":
                    {
                        calculation = (firstnum + secondnum);
                        textBox1.Text = calculation.ToString();
                    }
                    break;
                 case "-":
                    {
                        calculation = (firstnum - secondnum);
                        textBox1.Text = calculation.ToString();
                    }
                    break;
                case "/":
                    {
                        calculation = (firstnum / secondnum);
                        textBox1.Text = calculation.ToString();
                        break;
                    }
                case "*":
                    {
                        calculation = (firstnum * secondnum);
                        textBox1.Text = calculation.ToString();
                    }
                    break;

            }
              
 
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            getvalue();
            operate = "-";
            textBox1.Text = "-";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "0";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "1";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "2";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "3";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 3;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "4";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 4;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "5";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "6";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 6;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "7";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 7;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "8";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "9";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = textBox1.Text + 9;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getvalue();
            operate = "*";
            textBox1.Text = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}