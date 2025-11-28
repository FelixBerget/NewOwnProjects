namespace NewOwnProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store Rema1000 = new Store();
            Item FrozenPizza = new Item();
            FrozenPizza.Name = "Frossen Pizza";
            FrozenPizza.Price = 80;
            FrozenPizza.Stock = 15;
            Item CocaCola = new Item();
            CocaCola.Name = "Coca Cola";
            CocaCola.Price = 25;
            CocaCola.Stock = 100;
            FreshItem Apple = new FreshItem();
            Apple.Name = "Eple";
            Apple.Price = 10;
            Apple.Stock = 50;
            Apple.DaysLeft = 5;

            Rema1000.AddToList(FrozenPizza);
            Rema1000.AddToList(CocaCola);

            while (true)
            {
                string WritingString = (ReadLine("\nSøk", Rema1000));
                if (WritingString == "\n quit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine(WritingString);
                }
            }

        }

        public static string ReadLine(string line,Store store)
        {
            Console.WriteLine(line);
            string ReturnString = Console.ReadLine();
            if (ReturnString=="")
            {
                return "\n quit";
            }
            else if (IsString(ReturnString))
            {
                return store.GetProductByName(ReturnString);
            }
            return store.GetProductByIndex(Convert.ToInt32(ReturnString));
        }

        public static bool IsString(string line)
        {
            string CheckString = "0123456789";
            for(int i=0; i<line.Length; i++)
            {
                if (!CheckString.Contains(line[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
