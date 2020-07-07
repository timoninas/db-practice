using MySql.Data.MySqlClient;
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

namespace CS_operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorLabel.Text = "";
            dataAboutPerson.Rows.Add("1", "2");
            dataAboutPerson.Rows.Clear();
        }

        public string connectionString = "Data Source=4D97\\MSSSQLSERVER;Initial Catalog=CS;Integrated Security=True";

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();


            if (sqlConnection.State == ConnectionState.Open)
            {
                CS_DB db = new CS_DB();
                SqlConnection connection = db.getConnection();
                SqlCommand command1 = new SqlCommand();
                connection.Open();

                String userIDString = IDTextBox.Text.ToString();
                int userIDInt;

                if (int.TryParse(userIDString, out userIDInt))
                {
                    dataAboutPerson.Rows.Clear();
                    command1.CommandText = "SELECT * FROM GetConcreteCarByID(" + userIDInt.ToString() + ")";
                    command1.Connection = connection;

                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataAboutPerson.Rows.Add(reader[0], reader[1], reader[2], reader[3],
                                reader[4], reader[5], reader[6] + " " + reader[7], reader[8]);
                            
                             /*MessageBox.Show(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                                reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]));
                            */
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Error ID");
                }
                
            }
            else
            {
                MessageBox.Show("Error Connection");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
