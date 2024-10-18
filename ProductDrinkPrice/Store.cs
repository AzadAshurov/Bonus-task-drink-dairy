namespace ProductDrinkPrice
{
    internal class Store
    {

        public Product[] _products = new Product[0];
        public void DairyProductCount()
        {


        }
        public void Add(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
            Console.WriteLine("Touch grass");



        }



    }

}
