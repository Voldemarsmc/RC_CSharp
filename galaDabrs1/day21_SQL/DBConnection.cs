
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
            database = "todolist";
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
        
       
        public void GetTaskList()
        {
            string stm = "SELECT taskName, taskDescription From toDoList";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);


            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row.Field<String>(0) + " " + row.Field<String>(1));
            }
        }
        public void AddTasks()
        {


            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO toDoList(taskName, taskDescription) VALUES(@taskName, @taskDescription)";
                cmd.Prepare();


                cmd.Parameters.AddWithValue("@taskName", "to do");
                cmd.Parameters.AddWithValue("@taskDescription", "nothing");
                
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        

        public void DelTask()
        {
            
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "delete from toDoList where taskID='" + "1" + "';";
                cmd.ExecuteNonQuery(); 
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

       
    }
}
