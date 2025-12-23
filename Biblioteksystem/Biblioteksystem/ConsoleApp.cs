using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteksystem
{
    internal class ConsoleApp
    {
        private Library Library;

        public ConsoleApp() {
            Library = new Library();
        }

        public void start()
        {
            while (true)
            {
                Console.WriteLine("Hva vil du gjøre, legge til, slette eller søke");
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Ingen input");
                }
                else if (input == "legg til")
                {
                    Console.WriteLine("Først, tittel");
                    string title = Console.ReadLine();
                    Console.WriteLine("Så, forfatter");
                    string author = Console.ReadLine();
                    Console.WriteLine("Så, Dato, format 0000.00.00");
                    string releaseDateString = Console.ReadLine();
                    string[] stringArrayDate = releaseDateString.Split(".");
                    int[] intDate = new int[stringArrayDate.Length];
                    for (int i = 0; i < stringArrayDate.Length; i++)
                    {
                        int part = Convert.ToInt16(stringArrayDate[i]);
                        intDate[i] = part;
                    }
                    DateTime releaseDate = new DateTime(intDate[0], intDate[1], intDate[2]);
                    Library.AddBook(title, author, releaseDate);
                }
                else if (input == "slett")
                {
                    Console.WriteLine("Hvem vil du slette");
                    string whoToDelete = Console.ReadLine();
                    Library.RemoveBook(whoToDelete);
                }
                else if (input == "søk")
                { 
                    Console.WriteLine("Hvem vil du hente");
                    string whoToFind = Console.ReadLine();
                    Book b = Library.GetBook(whoToFind);
                    string releaseDateString = b.releaseDate.ToString("MMMM dd, yyyy");
                    Console.WriteLine("Tittel er " + b.title + " forfatter er " + b.author + " utgivelsesdato " + releaseDateString);
                }
                else
                {
                    Console.WriteLine("Feil input");
                }
            }

                
            }
    }
}
