using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day14_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttest_Click(object sender, EventArgs e)
        {
            lsttest.Items.Add(Convert.ToString(1));
            lsttest.Items.Add(Convert.ToString(2));
        }
    }
}
