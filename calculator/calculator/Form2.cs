using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username.Text == "ace" && password.Text=="***")
         {
                MessageBox.Show("welcome");
              
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("INCORRECT INFOMATION ,PLEASE TRY AGAIN");
                username.Clear();
                password.Clear();
                username.Focus();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
