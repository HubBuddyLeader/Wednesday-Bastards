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
        public fm_Database()
        {
            InitializeComponent();

            fillDisplay();
        }

        private void pbShitImage_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }

        private void fm_Database_Load(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.sortBox.SelectedIndex) {
                case 0: //ID
                    Database.Data.Sort(delegate(Item x, Item y) {
                        return x.Id.CompareTo(y.Id);
                    });
                    break;
                case 1: //Name
                    Database.Data.Sort(delegate (Item x, Item y) {
                        if (x.Name == null && y.Name == null) return 0;
                        else if (x.Name == null) return -1;
                        else if (y.Name == null) return 1;
                        else return x.Name.CompareTo(y.Name);
                    });
                    break;
                case 2: //Price
                    Database.Data.Sort(delegate (Item x, Item y) {
                        return x.Price.CompareTo(y.Price);
                    });
                    break;
                case 3: //stock
                    Database.Data.Sort(delegate (Item x, Item y) {
                        return x.Stock.CompareTo(y.Stock);
                    });
                    break;
            }
            fillDisplay();

            
        }

        public void fillDisplay() {
            lblId.Items.Clear();
            lblProduct.Items.Clear();
            lblPrice.Items.Clear();
            lblStock.Items.Clear();
            foreach (Item i in Database.Data)
            {
                lblId.Items.Add(i.Id);
                lblProduct.Items.Add(i.Name);
                lblPrice.Items.Add(i.Price);
                lblStock.Items.Add(i.Stock);
            }
        }

        private void lblId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
