using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    public class Country
    {
        public string Name {  get; private set; }
        public double MillPopulation { get; private set; }
        public Country(string name, double millPopulation)
        {
            MillPopulation = millPopulation;
            Name = name;
        }
        public string ToString()
        {
            return Name + " is a country with " + MillPopulation + " million people"; 
        }
    }
}
