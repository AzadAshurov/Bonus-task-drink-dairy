namespace ProductDrinkPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink product1 = new Drink(2.5m, "FF343", "Kefir", 10.5m);
            Store store = new Store();
            store.Add(product1);
            Console.WriteLine("Hello world!");




        }
    }
}