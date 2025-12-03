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

        public static void WriteDownwards(string input)
        {
            if (input.Length == 0)
            {
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        public static void ReversedInput(string input)
        {
            if (input.Length == 0)
            {
                return;
            }
            string finishString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                finishString += input[i];
            }
            Console.WriteLine(finishString);
        }
        public static void MakeIntoOneWord(string input)
        {
            if (input.Length == 0)
            {
                return;
            }
            string finishedString = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ') {
                finishedString+= input[i];
                }
            }
            Console.WriteLine(finishedString);
        }
        public static void MakeRandomWord(string input)
        {
            Random random = new Random();
            string finishedString = "";
            for (int i = 0; i < input.Length; ++i) {
                finishedString += input[random.Next(25)];
            }
            Console.WriteLine(finishedString);
        }
    }
}
