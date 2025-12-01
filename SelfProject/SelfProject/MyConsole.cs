using System;
using System.Collections.Generic;
using System.Text;

namespace SelfProject
{
    internal class MyConsole
    {

        public static string GetInfo(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }


        public static bool ReadBool(string input)
        {
            if(input == null) return false;
            if(input.Length == 0) return false;
            if (input == "true") return true;
            return false;

        }
    }
}
