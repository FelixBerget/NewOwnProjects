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
        public int Id { get; private set; }

        public Company(string name, string type, Country country)
        {
            Random r  = new Random();
            Id = r.Next(1, 1000000);
            Name = name;
            Type = type;
            Country = country;
        }
        public string ToString()
        {
            return "ID-"+ Id + " " +  Name + " is a " + Type + " company from " + Country.Name; 
        }
    }
}
