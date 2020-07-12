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
        ControllerFormAuth controller;
        public FormAuth()
        {
            InitializeComponent();

            this.controller = new ControllerFormAuth();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (controller.IsLogged(usernameTextBox.Text, passwordTextBox.Text))
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
