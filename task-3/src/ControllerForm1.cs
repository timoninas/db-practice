using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_operator
{
    class ControllerForm1
    {
        CS_DB db = new CS_DB();
        public static string connectionString = "Data Source=4D97\\MSSSQLSERVER;Initial Catalog=CS;Integrated Security=True";
        SqlConnection sqlConnectionCS = new SqlConnection(connectionString);

        public List<String> GetPersonByID(int id)
        {
            List<String> array =new List<String>();

            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT * FROM Person as p WHERE p.id = " + id.ToString();
            command1.Connection = connection;

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[2].ToString());
                    array.Add(reader[3].ToString());
                    array.Add(reader[4].ToString());
                }

            }

            return array;
        }

        public List<String> GetPersonInfoByID(int id)
        {
            List<String> array = new List<String>();

            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT pinf.paddress, pinf.pphone, pinf.pemail FROM Person as p JOIN PersonInfo as pinf ON p.id_personinfo = pinf.id WHERE p.id = " + id.ToString();
            command1.Connection = connection;

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[0].ToString());
                    array.Add(reader[1].ToString());
                    array.Add(reader[2].ToString());
                }

            }

            return array;
        }

        public List<String> GetCarsByID(int id)
        {
            List<String> array = new List<String>();

            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT mc.mcbrand, mc.mcmodel, cr.cnumber, cr.ccolor FROM Contracts as c JOIN Person as p ON c.id_person = p.id JOIN Car as cr ON c.id_car = cr.id JOIN ModelCar as mc ON cr.id_cmodel = mc.id WHERE p.id = " + id.ToString();
            command1.Connection = connection;

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[0].ToString());
                    array.Add(reader[1].ToString());
                    array.Add(reader[2].ToString());
                    array.Add(reader[3].ToString());
                }

            }

            return array;
        }

        public List<String> GetServicesByID(int id)
        {
            List<String> array = new List<String>();

            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT svc.saddress, cr.cnumber, svc.slongitude, svc.slatitude FROM Contracts as c JOIN Person as p ON c.id_person = p.id JOIN Serviec as svc ON c.id_service = svc.id JOIN Car as cr ON c.id_car = cr.id  WHERE p.id = " + id.ToString();
            command1.Connection = connection;

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[0].ToString());
                    array.Add(reader[1].ToString());
                    array.Add(reader[2].ToString());
                    array.Add(reader[3].ToString());
                }

            }

            return array;
        }

        public List<String> GetEquipmentsByPersonID(int id)
        {
            List<String> array = new List<String>();

            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT eq.id, eq.emei, eq.date_end_maintenance " +
                                   "FROM Contracts as c " +
                                  "JOIN Person as p ON c.id_person = p.id " +
                                  "JOIN Car as cr ON c.id_car = cr.id  " + 
                                  "JOIN Equipment as eq ON cr.id_equipment = eq.id " +
                                  "WHERE p.id = " + id.ToString() + 
                                  " ORDER BY eq.id DESC ";
            command1.Connection = connection;

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[0].ToString());
                    array.Add(reader[1].ToString());
                    array.Add(reader[2].ToString());
                }
            }

            return array;
        }

        public List<String> GetMessagesByPersonID(int id)
        {
            List<String> array = new List<String>();

            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT msg.id as id_message, " +
                                   "json_value(msg.value_json, '$.message'), " +
                                   "msg.date_with_date as date_with_time, " +
                                   "eq.emei, " +
                                   "json_value(msg.value_json, '$.longitude') as message_longitude, " +
                                   "json_value(msg.value_json, '$.latitude') as message_latitude " +
                                   "FROM Contracts as c " +
                                   "JOIN Person as p ON c.id_person = p.id " +
                                   "JOIN Car as cr ON c.id_car = cr.id " +
                                   "JOIN Equipment as eq ON cr.id_equipment = eq.id " +
                                   "JOIN Message as msg ON eq.id = msg.id_equipment " +
                                   "WHERE p.id = " + id.ToString() +
                                   "ORDER BY msg.date_with_date DESC ";
            command1.Connection = connection;

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[0].ToString());
                    array.Add(reader[1].ToString());
                    array.Add(reader[2].ToString());
                    array.Add(reader[3].ToString());
                    array.Add(reader[4].ToString());
                    array.Add(reader[5].ToString());
                }

            }

            return array;
        }

        public List<String> GetEquipmentMaintenanceByPersonID(int id)
        {
            List<String> array = new List<String>();

            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT * FROM CS.dbo.GetEquipmentMaintenanceByPersonID(" + id.ToString() + ") as formedTable ORDER BY formedTable.id_equipment";
            command1.Connection = connection;

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[0].ToString());
                    array.Add(reader[1].ToString());
                    array.Add(reader[2].ToString());
                    array.Add(reader[3].ToString());
                }

            }

            return array;
        }

        public List<String> GetConfigByID(int id)
        {
            List<String> array = new List<String>();

            db.openConnection();
            SqlConnection connection = db.getConnection();
            SqlCommand command1 = new SqlCommand();

            command1.CommandText = "SELECT * FROM GetAllDataAboutPersonCars(" + id.ToString() + ")" ;
            command1.Connection = connection;

            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    array.Add(reader[0].ToString());
                    array.Add(reader[1].ToString());
                    array.Add(reader[2].ToString());
                    array.Add(reader[3].ToString());
                    array.Add(reader[4].ToString());
                    array.Add(reader[5].ToString());
                }

            }

            return array;
        }
    }
}
