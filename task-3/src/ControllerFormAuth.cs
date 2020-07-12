using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_operator
{
    class ControllerFormAuth
    {
        private CS_DB db = new CS_DB();

        public bool IsLogged(string username, string password)
        {
            this.db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT * FROM Operator as op WHERE op.username = '" + username + "' AND op.password = '" + password + "'";
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
                return true;
            }

            return false;
        }
    }
}
