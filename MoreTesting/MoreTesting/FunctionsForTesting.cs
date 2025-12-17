using System;
using System.Collections.Generic;
using System.Text;

namespace MoreTesting
{
    public class FunctionsForTesting
    {

        public FunctionsForTesting() { }
        public string RandomizeCase(string input,Random r)
        {
            string ReturnString = "";
            for (int i = 0; i < input.Length; i++)
            {
                int RandomNum = r.Next(2);
                if (RandomNum == 0)
                {
                    ReturnString += Char.ToUpper(input[i]);
                }
                if (RandomNum == 1)
                {
                    ReturnString += Char.ToLower(input[i]);
                }
            }
            return ReturnString;
        }
        public string VerticalString(string Input)
        {
            string ReturnString = "";
            for(int i = 0; i < Input.Length; i++)
            {
                if (Input[i]==' ' && i != Input.Length -1)
                {
                    ReturnString += "\n";
                }
                else if(i != Input.Length - 1)
                {
                    ReturnString += Input[i] + "\n";
                }
                else if(Input[i] == ' ')
                {
                }
                else
                {
                    ReturnString += Input[i];
                }
            }
            return ReturnString;
        }
    }
}
