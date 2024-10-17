namespace ProductDrinkPrice
{
    internal class Drink : Product
    {
        public decimal _alcoholPersent;
        public Drink(decimal alcoholPersent, string no, string name, decimal price) : base(no, name, price)
        {
            _alcoholPersent = alcoholPersent;
        }

    }
}
