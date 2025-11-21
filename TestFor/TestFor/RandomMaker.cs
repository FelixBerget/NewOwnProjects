using System;
using System.Collections.Generic;
using System.Text;

namespace TestFor
{
    internal class RandomMaker
    {
        public static int randomNum = 0;

        public static void setRandom()
        {
            var random = new Random();
            randomNum = random.Next(1, 100);
        } 
    }
}
