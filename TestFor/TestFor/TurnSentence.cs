using System;
using System.Collections.Generic;
using System.Text;

namespace TestFor
{
    internal class TurnSentence
    {

        public static void turnTheSenctence()
        {
            Console.WriteLine("Skriv in setning som skal snus");
            string line = Console.ReadLine();
            string returnLine = "";
            for(int i = line.Length-1; i >= 0; i--)
            {
                returnLine += line[i];
            }
            Console.WriteLine(returnLine);
        }
    }
}
