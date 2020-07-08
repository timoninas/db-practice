using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_operator
{
    public partial class FormAuth : Form
    {
        CS_DB db = new CS_DB();
        public FormAuth()
        {
            InitializeComponent();
            SqlConnection connection = db.getConnection();
            //usernameTextBox;
            //passwordTextBox;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT * FROM Operator as op WHERE op.username = '" + usernameTextBox.Text + "' AND op.password = '" + passwordTextBox.Text + "'";
            command1.Connection = connection;

            List<string> array = new List<string>();

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[0].ToString());
                }
            }

            if (array.Count > 0)
            {
                this.Hide();
                Form1 nextWindow = new Form1(usernameTextBox.Text, passwordTextBox.Text);
                nextWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Такого оператора не существует");
            }
        }
    }
}
