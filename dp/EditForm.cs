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
    public partial class EditForm : Form
    {
        string selected;
        int index;
        public EditForm()
        {
            InitializeComponent();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Database.Data.Count; i++)
            {
                comboBox1.Items.Add(Database.Data[i].Name);
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void grpInputData_Enter(object sender, EventArgs e)
        {
            // Do nothing..
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            for (int i = 0; i < Database.Data.Count; i++)
            {
                if (Database.Data[i].Name == selected)
                {
                    index = i;
                    txtProduct.Text = Database.Data[i].Name;
                    //	txtStock.Text = Database.Data[i].Stock;
                    //	txtPrice.Text = Database.Data[i].Price;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            Database.Data[index].Name = txtProduct.Text;
            //	txtStock.Text = Database.Data[i].Stock;
            //	txtPrice.Text = Database.Data[i].Price;
        }

        private void EditForm_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Database.Data.Count; i++)
            {
                comboBox1.Items.Add(Database.Data[i].Name);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            for (int i = 0; i < Database.Data.Count; i++)
            {
                if (Database.Data[i].Name == selected)
                {
                    index = i;
                    txtProduct.Text = Database.Data[i].Name;
                    //	txtStock.Text = Database.Data[i].Stock;
                    //	txtPrice.Text = Database.Data[i].Price;
                }
            }
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }
    }
}