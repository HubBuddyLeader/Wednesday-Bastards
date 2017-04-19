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
            //PRoduct input
            if (!this.txtProduct.Text.All(c => Char.IsLetter(c)))
            {
                _validate += "Product name must contain only alphebetical characters";
            }
            else {
                _name = this.txtProduct.Text;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.txtPrice.Text, out _price)) {
                _validate += " Price must be a number, ";
            }
            //Price input
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtPrice.Text, out _stock)){
                _validate += " Stock must be a full number, ";
            }
            //Stock input
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Item newItem = new Item(_name, _stock, _price,_id);
            _id++;
        }
    }
}
