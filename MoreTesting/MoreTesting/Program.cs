namespace MoreTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            FunctionsForTesting FunTest = new FunctionsForTesting();
            Console.WriteLine(FunTest.RandomizeCase("Harry",r));
            Console.WriteLine(FunTest.VerticalString("Harry er stor"));
        }
    }
}
