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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string query = "select numcase,data_ from court;";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm1 = new Form4();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }
    }
}
