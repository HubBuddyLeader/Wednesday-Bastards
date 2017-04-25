using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp
{
    public partial class fm_Database : Form
    {

        AddForm addForm = new AddForm();
        EditForm editForm = new EditForm();

        public fm_Database()
        {
            InitializeComponent();
        }

        private void pbShitImage_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editForm.Show();
        }

        private void fm_Database_Load(object sender, EventArgs e)
        {
            Database.Data.Add(new Item("item1", 4, 5, 0));
            Database.Data.Add(new Item("data2", 43, 52, 1));
            Database.Data.Add(new Item("item3", 4, 5, 0));

           // lbProduct.Items.Add("NAME" + "  " + "Stock" + " " + "Price");
            for (int i = 0; i < Database.Data.Count; i++)
            {
                lbProduct.Items.Add(Database.Data[i].Name);
                lbPrice.Items.Add(Database.Data[i].Price.ToString());
                lbStock.Items.Add(Database.Data[i].Stock.ToString());
            }
           
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }


    }
}
