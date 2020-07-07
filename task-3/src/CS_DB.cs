using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_operator
{

    class CS_DB
    {
        //static public String connectionString = "Data Source=4D97\\MSSSQLSERVER;Initial Catalog=CS;Integrated Security=True";

        private SqlConnection connection = new SqlConnection("Data Source=4D97\\MSSSQLSERVER;Initial Catalog=CS;Integrated Security=True");

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }    
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
