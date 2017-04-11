using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp
{
    class Item
    {
        private int _stock;
        private string _name;
        private double _price;

        public Item(string name, int stock, double price) {
            _name = name;
            _stock = stock;
            _price = price;
        }

        public int Stock {
            set {_stock = value;}
            get {return _stock;}  
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public double Price
        {
            set { _price = value; }
            get { return _price; }
        }
    }
}
