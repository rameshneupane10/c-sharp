using System.Data.SqlClient;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operate= "";
        decimal calculation = 0;
        SqlConnection conn = new SqlConnection("Data Source= DESKTOP-08I2U23\\SQLEXPRESS;Initial catalog=bit3rdsem;user id =sa ;password=kist@123;");
        
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

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "Insert into Student values('sandip','samakhushi','98476767','NIST')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Insertion failed");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "Update Student set name='srijana',address='lalitpur',contact='980000000',college='kist' where id=3" ;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("updated successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"update failed");
            }
            

        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "Delete from Student where id=12";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"deletion failed");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1", "ace", "eastblue","012345","kist");
        }
    }
}