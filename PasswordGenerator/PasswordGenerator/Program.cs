namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor mange tegn");
            string arg1 = Console.ReadLine();
            Console.WriteLine("Hvilke tegn");
            string arg2 = Console.ReadLine();
            Producer.generator(arg1, arg2); 
        }
    }
}
