using System;
using System.Collections.Generic;
using System.Text;

namespace OwnProject
{
    internal class Dinosaur
    {
        string name;
        string description;
        string type;
        public Dinosaur(string newName, string newDescription, string newType) { 
            name = newName;
            description = newDescription;
            type = newType;
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
    }
}
