using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security;
using System.Text;

namespace OwnProject
{
    public class Dinosaur : Lizard
    {
        public Dinosaur(string newName, string newDescription, string newType, string newLength, string newWeight, string newSound) { 
            name = newName;
            description = newDescription;
            type = newType;
            length = newLength;
            weight = newWeight;
            sound = newSound;
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
