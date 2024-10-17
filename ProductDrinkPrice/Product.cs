namespace ProductDrinkPrice
{
    internal class Product
    {
        public string _no;
        public string _name;
        public decimal _price;

        string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Too short");
                }
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("iNCORRECT price");
                }
                else
                {
                    _price = value;
                }
            }
        }




        public Product(string no, string name, decimal price)
        {
            _no = no;
            Name = name;
            Price = price;

        }

    }
}
