﻿using System;
using System.Windows.Forms;

namespace dp
{
    public partial class EditForm : Form
    {
        private string selected;
        private int index;

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
            onClose();
            this.Close();
        }

        private void grpInputData_Enter(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Database.Data[index].Name = txtProduct.Text;
            Database.Data[index].Stock = Convert.ToInt32(txtStock.Text);
            Database.Data[index].Price = Convert.ToInt32(txtPrice.Text);
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
                    txtStock.Text = Database.Data[i].Stock.ToString();
                    txtPrice.Text = Database.Data[i].Price.ToString();
                }
            }
        }

        private void onClose()
        {
            // What to do when window is closed by either x or button.
            if (System.Windows.Forms.Application.OpenForms["fm_Database"] != null) // Gets current instance.
            {
                (System.Windows.Forms.Application.OpenForms["fm_Database"] as fm_Database).fillDisplay();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            onClose();
        }
        private void lblProduct_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }
    }
}
