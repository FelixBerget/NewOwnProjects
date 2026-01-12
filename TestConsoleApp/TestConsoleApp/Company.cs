using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    public class Company
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public Country Country { get; private set; }

        public Company(string name, string type, Country country)
        {
            Name = name;
            Type = type;
            Country = country;
        }
        public string ToString()
        {
            return Name + " is a " + Type + " company from " + Country.Name; 
        }
    }
}
