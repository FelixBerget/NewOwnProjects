using System;
using System.Collections.Generic;
using System.Text;

namespace DiffArray
{
    internal class ThreeNums
    {
        public static void biggest()
        {
            Console.WriteLine("Første tall");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Andre tall");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tredje tall");
            int thirdNumber  = Convert.ToInt32(Console.ReadLine());

            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber > thirdNumber && secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine(thirdNumber);
            }
            else
            {
                Console.WriteLine("Topp tallene er like");
            }
        }
    }
}
