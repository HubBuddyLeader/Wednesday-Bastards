namespace dp
{
    public class Item
    {
        private int _stock, _id;
        private string _name;
        private double _price;

        public Item(string name, int stock, double price, int id) {
            _name = name;
            _stock = stock;
            _price = price;
            _id = id;
        }

        public int Stock {
            set {_stock = value;}
            get {return _stock;}  
        }
        public int Id
        {
           // set { _id = value; }
            get { return _id; }
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
