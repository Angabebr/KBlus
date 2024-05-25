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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            fillCourtTable();
        }
        private void fillCourtTable()
        {
            string query = "select * from court;";

            string connectionString = "Server=DESKTOP-MHIOKQG\\SQLEXPRESS;Database=judgment;Integrated Security=True";
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
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }
    }
}
