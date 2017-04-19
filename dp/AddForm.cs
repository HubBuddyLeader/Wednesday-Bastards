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
    public partial class AddForm : Form
    {
        Form secondForm = new Form();

        private String _name, _validate = "";
        private int _id = 0, _stock;
        private double _price;
        public AddForm()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
                //add item to dataBase
                Database.Data.Add(new Item(_name, _stock, _price, _id));
                _id++;
                this.errorLabel.Text = "FUCK! IT WORKED!" + Database.Data[0].Name; //+ Database.Data[1].Name;
                this.errorLabel.Show();
            }
            else {
                //Display error then clear
                this.errorLabel.Text += _validate;
                this.errorLabel.Show();
                _validate = "";

            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
