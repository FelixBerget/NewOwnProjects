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

        public static void ChangeColor(ConsoleColor foreColor,ConsoleColor backColor)
        {
            Console.ForegroundColor = foreColor;
            Console.ForegroundColor = backColor;
        }
    }
}
