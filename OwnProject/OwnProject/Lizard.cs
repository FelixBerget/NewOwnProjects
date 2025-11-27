using System;
using System.Collections.Generic;
using System.Text;

namespace OwnProject
{
    public class Lizard
    {
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string length { get; set; }
        public string weight { get; set; }
        public string sound { get; set; }
        public string makeSound()
        {
            return sound;
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
