using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    internal class ConsoleApp
    {
        private Zoo zoo;
        public ConsoleApp()
        {
            zoo = new Zoo();
        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Velkommen til portalen til dyreparken");
                Console.WriteLine("Her kan du gå gjennom infoen til dyreparken og endre dataene");
                Console.WriteLine("Kommandoene er (legg til) (fjern dyr) (skriv ut infoen) (søk basert på art)");
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Ingen input");
                }
                else if (input.ToLower() == "legg til")
                {
                    Console.WriteLine("Først skriv inn art");
                    string species = Console.ReadLine();
                    Console.WriteLine("Så skriv inn navn");
                    string name = Console.ReadLine();
                    Console.WriteLine("Så skriv inn alder");
                    string age = Console.ReadLine();
                }
            }
    }
}
