using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    internal class Zoo
    {
        private List<Animal> animals;
        public Zoo()
        {
            animals = new List<Animal>();
        }
        public List<Animal> GetAnimals()
        {
            return animals;
        }
        public List<Animal>GetSpecificAnimal(string species)
        {
            return animals.Where(x => x.GetSpecies().ToLower() == species.ToLower()).ToList();
        }
        public void AddAnimal(string name, string species, int age)
        {
            Animal a = new Animal(name,species,age);
            animals.Add(a);
        }
        public void RemoveAnimal(string name)
        {
            animals.RemoveAll(x=> x.GetName().ToLower() == name.ToLower());
        }
    }
}
