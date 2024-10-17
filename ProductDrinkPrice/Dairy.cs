namespace ProductDrinkPrice
{
    internal class Dairy : Product
    {
        public decimal _fatPersent;
        public Dairy(decimal fatPersent, string no, string name, decimal price) : base(no, name, price)
        {
            _fatPersent = fatPersent;


        }
    }
}
