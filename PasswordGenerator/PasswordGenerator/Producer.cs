using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator
{
    internal class Producer
    {
        static readonly Random Random = new Random();
        public static void generator(string arg1 ,string arg2)
        {
            if (!IsValid(arg1,arg2))
            {
                ShowHelpText();
                return;
            }
            int firstArg = Convert.ToInt32(arg1);
            string response = "";
            var lowerCase = arg2.Count(x => x == 'l');
            var upperCase = arg2.Count(x => x == 'L');
            var specialCase = arg2.Count(x => x == 's');
            var numberCases = arg2.Count(x => x == 'd');
            for (int i = 0; i < lowerCase;i++)
            {
                response += WriteRandomLowerCaseLetter();
            }
            for (int i = 0; i < upperCase;i++)
            {
                response += WriteRandomUpperCaseLetter();
            }
            for (int i = 0; i < specialCase; i++)
            {
                response += WriteRandomSpecialCharacter();
            }
            for (int i = 0; i < numberCases; i++)
            {
                response += WriteRandomDigit();
            }
            firstArg = firstArg - lowerCase - upperCase - specialCase - numberCases;

            for (int i = 0; i < firstArg; i++)
            {
                int randomPlacement = Random.Next(0, response.Length);
                string[] responseArray = {"",""};
                for(var j = 0; j < randomPlacement; j++)
                {
                    responseArray[0] += response[j];
                }
                for (var j = randomPlacement; j < response.Length; j++)
                {
                    responseArray[1] += response[j];
                }
                var randomNum = Random.Next(0, 4);
                if(randomNum == 0)
                {
                    responseArray[0] += WriteRandomDigit();
                }
                if(randomNum == 1)
                {
                    responseArray[0] += WriteRandomLowerCaseLetter();
                }
                if (randomNum == 2)
                {
                    responseArray[0] += WriteRandomUpperCaseLetter();
                }
                if (randomNum == 3) { 
                    responseArray[0] += WriteRandomSpecialCharacter();
                }
                response = responseArray[0] + responseArray[1];

            }
            Console.WriteLine(response);
        }
        public static void ShowHelpText()
        {
            Console.WriteLine("PasswordGenerator  \r\nOptions:\r\n- l = liten bokstav\r\n- L = stor bokstav\r\n- d = siffer\r\n- s = spesialtegn (!\"#¤%&/(){}[]\r\nEksempel: PasswordGenerator 14 lLssdd\r\n    betyr\r\n        Min. 1 liten bokstav\r\n        Min. 1 1 stor bokstav\r\n        Min. 2 spesialtegn\r\n        Min. 2 sifre\r\n        Lengde på passordet skal være 14");
        }

        public static bool IsValid(string arg1,string arg2)
        {
            if(arg1 == "" || arg2 == "")
            {
                return false;
            }
            int arg1Num = Convert.ToInt32(arg1);
            int arg2Num = arg2.Length;
            if(arg1Num < arg2Num)
            {
                return false;
            }
            return true;
        }

        public static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'x');
        }

        public static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'X');
        }
        public static string WriteRandomDigit()
        {
            return Random.Next(0, 10) + "";
        }
        public static char WriteRandomSpecialCharacter()
        {
            string listOfChars = "#/?!:;";
            int rand = Random.Next(0, listOfChars.Length);
            return listOfChars[rand];
        }

        static char GetRandomLetter(char min, char max)
        {
            return (char)Random.Next(min, max);
        }
    }
}
