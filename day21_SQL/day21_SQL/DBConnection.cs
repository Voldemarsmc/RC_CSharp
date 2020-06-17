
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace day21_SQL
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        public DBConnection()
        {
            server = "127.0.0.1";
            database = "ofiss";
            user = "root";
            password = "voldemArs123";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; " +
                "SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                connection.Open();

                Console.WriteLine("Success");

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void GetEmployees()
        {
            string stm = "SELECT employeeName, employeeLastName FROM employees";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);


            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row.Field<String>(0) + " " + row.Field<String>(1));
            }
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------
        public void InsertEmployees()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO employees(employeeName, employeeLastname) VALUES(@employeeName, @employeeLastname)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
