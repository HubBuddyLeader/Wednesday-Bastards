﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace dp
{
    public partial class AddForm : Form
    {
        private String _name, _validate = "";
        private int _id = 0, _stock;
        private double _price;

        public AddForm()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
			// Do nothing...
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onClose();
            this.Close();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            onClose();
        }

        private void onClose() {
            // What to do when window is closed by either x or button
            if (System.Windows.Forms.Application.OpenForms["fm_Database"] != null) // Gets current instance
            {
                (System.Windows.Forms.Application.OpenForms["fm_Database"] as fm_Database).fillDisplay();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.errorLabel.Text = "";

            //Validation
            this.errorLabel.Text = "Error : \n";

            if (!this.txtProduct.Text.All(c => Char.IsLetter(c)))
            {
                _validate += "Product name must contain only alphebetical characters \n";
            }
            else {
                _name = this.txtProduct.Text;
            }
            if (!double.TryParse(this.txtPrice.Text, out _price))
            {
                _validate += "Price must be a number \n";
            }
            if (!int.TryParse(this.txtStock.Text, out _stock))
            {
                _validate += "Stock must be a full number \n";
            }

            if (_validate == "")
            {
                this.errorLabel.Hide();
                // Add item to dataBase
                Database.Data.Add(new Item(_name, _stock, _price, _id));
                _id++;
                this.errorLabel.Text = "Recorded added successfully! " + Database.Data[Database.Data.Count-1].Name;
                this.errorLabel.Show();

                // Clear Boxes
                this.txtProduct.Text = "";
                this.txtPrice.Text = "";
                this.txtStock.Text = "";
            }
            else {
                // Display error then clear
                this.errorLabel.Text += _validate;
                this.errorLabel.Show();
                _validate = "";
            }
        }
    }
}
