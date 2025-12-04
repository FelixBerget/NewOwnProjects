namespace ThisAndBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food pizza = new Food();
            Console.WriteLine(pizza.GetName());
            HotDog pizzaHotDog = new HotDog();
            Console.WriteLine(pizzaHotDog.GetPrice());
        }
    }
}
