using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace OwnProject
{
    internal class DinoFacts
    {
        static List<Dinosaur> Dinosaurs = new List<Dinosaur>();
        public static void addDino(Dinosaur dinosaur)
        {
            Dinosaurs.Add(dinosaur);
        }
        public static int getListLength()
        {
            return Dinosaurs.Count; 
        }
        public static string getMenu()
        {
            string returnString = "\n";
            for (int i = 0; i < Dinosaurs.Count; i++)
            {
                returnString += "\n Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
            }
            return returnString;
        }

        public static string GetHelp()
        {

            return "\n For meny skriv (meny), for spesifikke dinosaur typer skriv arttypen f.eks.(theropod), for å søke i beskrivelsen som f.eks. kjøtteter skriv (søk), for å søke direkte etter navn så skriv (navnsøk), og for dinosaur så skriv f.eks. (2) Skriv til dinosaur eller krokodille når du søker etter lyd\n";
        }
        public static string getDinoInfo(int index)
        {
            if (index > Dinosaurs.Count - 1){
                return "\n Indeks eksisterer ikke for dinosaur\n";
            }
            string returnString =  "\n " + Dinosaurs[index].getName() + "\n " + Dinosaurs[index].getType() + " \n Info under\n\n " + Dinosaurs[index].getDescription() + " \n " + Dinosaurs[index].getLength() + " meter lang potensielt \n " + Dinosaurs[index].getWeight() + " tonn tung potensielt \n";
            return returnString;
        }
        public static string getAllOfSource(string type)
        {
            string returnString = "\n";
            string lowerType = type.ToLower();
            for (int i = 0; i < Dinosaurs.Count; i++)
            {
                if (Dinosaurs[i].getType().ToLower() == lowerType)
                {
                    returnString += "\n Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
                }
            }
            return returnString;
        }
        public static string searchInDescriptions(string searchWith)
        {
            string returnString = "\n";
            string searchWithLower = searchWith.ToLower();
            for(int i = 0; i< Dinosaurs.Count; i++)
            {
                string searchInLower = Dinosaurs[i].getDescription().ToLower();
                if (searchInLower.Contains(searchWithLower)){
                    returnString += "\n Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
                }
            }
            return returnString;
        }
        public static string getDinosaurByName(string name)
        {
            string searchName = name.ToLower();
            string returnString = "";
            for(int i = 0;i< Dinosaurs.Count; i++)
            {
                string searchInLower = Dinosaurs[i].getName().ToLower();
                if (searchInLower==searchName)
                {
                    return getDinoInfo(i);
                }
            }
            return "\n Finner ikke dinosauren \n ";
        }

        public static string getByWeight(string firstWeigth, string secondWeigth) {
            string returnString = "";
            double firstWeightInt = Convert.ToDouble(firstWeigth);
            double secondWeightInt = Convert.ToDouble(secondWeigth);
            for (int i = 0; i < Dinosaurs.Count; i++)
            {
                if (Convert.ToDouble(Dinosaurs[i].getWeight())<secondWeightInt && Convert.ToDouble(Dinosaurs[i].getWeight())> firstWeightInt)
                {
                    returnString += "\n Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
                }
            }
            return returnString;

        }

        public static string makeSound(int index)
        {
            if (index > Dinosaurs.Count - 1)
            {
                return "\n Indeks eksisterer ikke i dinosaurer\n";
            }
            string returnString = "\n " + Dinosaurs[index].makeSound() + "\n";
            return returnString;
        }
    }
}
