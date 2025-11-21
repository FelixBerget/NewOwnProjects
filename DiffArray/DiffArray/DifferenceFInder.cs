using System;
using System.Collections.Generic;
using System.Text;

namespace DiffArray
{
    internal class DifferenceFInder
    {

        public static void find()
        {
            Console.WriteLine("Start nummer");
            int startNumberString = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Slutt nummer");
            int endNumberString = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Differanse");
            int diff = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = startNumberString; i <= endNumberString; i += diff)
            {
                Console.WriteLine(i);
            }

        }
    }
}
