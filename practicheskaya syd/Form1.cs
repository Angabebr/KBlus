using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Парктичискааяяяяяяяяяяяяяя
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                string login = textBox2.Text;
                string password = textBox1.Text;

                string connectionString = "Server=510-13;Database=judgment;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM autoriz WHERE login_=@login AND password_=@password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);
                        int result = (int)command.ExecuteScalar();
                        if (result > 0)
                        {
                        Form2 form2 = new Form2();
                        this.Hide(); 
                        form2.Show();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль");
                        }
                    }
                }
            }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
