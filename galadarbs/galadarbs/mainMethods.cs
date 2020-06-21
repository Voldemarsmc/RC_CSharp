using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace galadarbs
{
    class mainMethods
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        
        public void connectinon()
        {
            server = "127.0.0.1";
            database = "todolist";
            user = "root";
            password = "voldemArs123";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; " +
                "SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);

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
        }
    }
}
