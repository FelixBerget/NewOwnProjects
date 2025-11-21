using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OwnProject
{
    internal class Dinosaur
    {
        string name;
        string description;
        string type;
        string length;
        public Dinosaur(string newName, string newDescription, string newType, string newLength) { 
            name = newName;
            description = newDescription;
            type = newType;
            length = newLength;
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
    }
}
