using System;
using System.Collections.Generic;
using System.Text;

namespace OwnProject
{
    public class Crocodilian : Lizard
    {
        public string teethNumber { get; set; }
        public string getTeethNumber()
        {
            return teethNumber;
        }

        public string getName()
        {
            return name;
        }
        public string getDescription()
        {
            return description;
        }
        public string getType()
        {
            return type;
        }
        public string getLength()
        {
            return length;
        }
        public string getWeight()
        {
            return weight;
        }
    }
}
