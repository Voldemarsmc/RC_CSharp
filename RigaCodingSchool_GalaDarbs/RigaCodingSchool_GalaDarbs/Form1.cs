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
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        public DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRecords();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GetRecords()
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select = from tbl_tasks", conn);
            adapter.Fill(ds, "tbl_tasks");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_tasks";
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("insert into tbl_tasks (task_name) VALUES ('" + textBox1.Text + "')", conn);
            adapter.Fill(ds, "tbl_tasks");
            textBox1.Clear();
            GetRecords();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {

        }
    }
}
