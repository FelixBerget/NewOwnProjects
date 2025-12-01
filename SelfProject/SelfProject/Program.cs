namespace SelfProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string returnValue = MyConsole.GetInfo("What do you want to say");
                Console.BackgroundColor= ConsoleColor.White;
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(returnValue);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor= ConsoleColor.White;
                bool truth = MyConsole.ReadBool(returnValue);
                Console.WriteLine(truth);

            }
        }
    }
}
