using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day14_MD
{
    public partial class Form1 : Form
    {
        private List<String> OldList;
        public Form1()
        {
            InitializeComponent();

            OldList = new List<string>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(inputBox.Text != "")
            {
                lstElements.Items.Add(inputBox.Text);
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstElements.SelectedItems)
            {
                item.Remove();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lstElements.SelectedItems[0].Text = inputBox.Text;
        }

        private bool IsDuplicate(String element)
        {
            foreach(ListViewItem item in lstElements.Items)
            {
                if(inputBox.Text == item.Text)
                {
                    return true;
                }
            }
            return false;
        }


        private void ToStringList()
        {

        }
        private void ToListView()
        {

        }
    }
}
