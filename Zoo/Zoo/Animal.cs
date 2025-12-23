using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    internal class Animal
    {
        private string name;
        private string species;
        private int age;
        public Animal(string name, string species, int age)
        {
            this.name = name;
            this.species = species;
            this.age = age;
        }

        public string GetName()
        {
            return name; 
        }
        public string GetSpecies()
        {
            return species;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSpecies(string species)
        {
            this.species=species;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
