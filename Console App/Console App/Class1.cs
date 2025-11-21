using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App
{
    internal class Class1
    {
        public static string callAndResponse(string question)
        {
            Console.WriteLine(question + " ");
            string response = Console.ReadLine();
            if (response == "4" && question== "What is 2 + 2")
            {
                return ("Riktig svar! " + response);
            }
            else
            {
                return (response + " er responsen din til callen");
            }
            

        }
        public static string callAndResponse()
        {
            return callAndResponse("I am calling");
        }
    }

}
