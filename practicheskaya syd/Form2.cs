using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Парктичискааяяяяяяяяяяяяяя
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text !="") {
                string query = "select * from autoriz where password_='"+textBox6.Text+"';";

                string connectionString = "Server=510-13;Database=judgment;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                     
                    SqlCommand sqlCommand = connection.CreateCommand();
                    sqlCommand.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    DataTable result = new DataTable();
                        adapter.Fill(result);
                    if (result.Rows.Count > 0)
                    {
                        query = $"INSERT INTO court(numcase,data_,addres,information,judge,defendant) values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox7.Text}')";
                        sqlCommand.CommandText = query;
                        adapter.Fill(new DataTable());
                        MessageBox.Show("GOOD");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
            fillCourtTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm1 = new Form3();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fillCourtTable();
        }

        private void fillCourtTable()
        {
            string query = "select * from court;";

            string connectionString = "Server=510-13;Database=judgment;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable result = new DataTable();
                adapter.Fill(result);
                dataGridView1.DataSource = result;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm1 = new Form6();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
