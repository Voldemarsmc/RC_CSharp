using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RigaCodingSchool_GalaDarbs
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; User Id=voldemars-admin; Password='voldemArs123'; Database=testForC#");
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT * FROM todolist", connection);
            
        }
    }
}
