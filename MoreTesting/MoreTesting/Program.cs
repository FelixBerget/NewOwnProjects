namespace MoreTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            FunctionsForTesting FunTest = new FunctionsForTesting();
            Console.WriteLine(FunTest.RandomizeCase("Harry",r));
        }
    }
}
