using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    public class City
    {
        public string Name { get; private set; }    
        public Country Country { get; private set; }

        public double MillPopulation { get; private set; }
        public City (string name, Country country, double millPopulation) 
        {
            Name = name;
            Country = country;
            MillPopulation = millPopulation;
        }
        public string ToString()
        {
            return Name + " in " + Country.Name + " has " + MillPopulation + " million people";
        }
        
    }
}
