namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country Japan = new Country("Japan", 120);
            City Tokyo = new City("Tokyo", Japan, 32);
            Company Toyota = new Company("Toyota", "Car", Japan);
            Console.WriteLine(Japan.ToString());
            Console.WriteLine(Tokyo.ToString());
            Console.WriteLine(Toyota.ToString());
        }
    }
}
