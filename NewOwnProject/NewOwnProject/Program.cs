namespace NewOwnProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store Rema1000 = new Store();
            Item FrozenPizza = new Item("Frozen Pizza", 70, 10);
            Item CocaCola = new Item("Coca Cola", 25, 100);
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
