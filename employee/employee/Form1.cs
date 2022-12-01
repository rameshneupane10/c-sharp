using System.Data.SqlClient;
using System.Data;

namespace employee
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-08I2U23\SQLEXPRESS;
                                                Initial Catalog=employee;
                                                user id=sa;password=kist@123;");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-08I2U23\SQLEXPRESS;
                                                Initial Catalog=employee;
                                                user id=sa;password=kist@123;");

            con.Open();

            string Query = "select * from emp";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into emp values('" + textBox2.Text
                + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update emp set name='" + textBox2.Text + "', address='" + textBox3.Text + "' ,salary ='" + textBox4.Text + "' where id = '" + textBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from emp where id = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            con.Close();
        }
    }
}