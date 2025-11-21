using System;
using System.Collections.Generic;
using System.Reflection;
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

        public static string getMenu()
        {
            string returnString = "";
            for (int i = 0; i < Dinosaurs.Count; i++)
            {
                returnString += "Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
            }
            return returnString;
        }

        public static string GetHelp()
        {

            return "For meny skriv (meny), for spesifikke dinosaur typer skriv arttypen f.eks.(theropod), for å søke i beskrivelsen som f.eks. kjøtteter skriv (søk), for å søke direkte etter navn så skriv (navnsøk), og for dinosaur så skriv f.eks. (2)\n";
        }
        public static string getDinoInfo(int index)
        {
            if (index > Dinosaurs.Count - 1){
                return "Indeks eksisterer ikke\n";
            }
            string returnString = Dinosaurs[index].getName() + "\n" + Dinosaurs[index].getType() + "\nInfo under\n" + Dinosaurs[index].getDescription() + "\n";
            return returnString;
        }

        public static string getAllTheropods()
        {
            string returnString = "";
            for (int i = 0; i < Dinosaurs.Count; i++)
            {
                if (Dinosaurs[i].getType() == "Theropod")
                {
                    returnString += "Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
                }
            }
            return returnString;
        }
        public static string getAllSauropods()
        {
            string returnString = "";
            for (int i = 0; i < Dinosaurs.Count; i++)
            {
                if (Dinosaurs[i].getType() == "Sauropod")
                {
                    returnString += "Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
                }
            }
            return returnString;
        }
        public static string getAllHadrosaurs()
        {
            string returnString = "";
            for (int i = 0; i < Dinosaurs.Count; i++)
            {
                if (Dinosaurs[i].getType() == "Hadrosaur")
                {
                    returnString += "Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
                }
            }
            return returnString;
        }
        public static string searchInDescriptions(string searchWith)
        {
            string returnString = "";
            string searchWithLower = searchWith.ToLower();
            for(int i = 0; i< Dinosaurs.Count; i++)
            {
                string searchInLower = Dinosaurs[i].getDescription().ToLower();
                if (searchInLower.Contains(searchWithLower)){
                    returnString += "Nummmer " + i + " - " + Dinosaurs[i].getName() + "\n";
                }
            }
            return returnString;
        }
        public static string getDinosaurByName(string name)
        {
            string searchName = name.ToLower();
            string returnString;
            for(int i = 0;i< Dinosaurs.Count; i++)
            {
                string searchInLower = Dinosaurs[i].getName().ToLower();
                if (searchInLower==searchName)
                {
                    return Dinosaurs[i].getName() + "\n" + Dinosaurs[i].getType() + "\nInfo under\n" + Dinosaurs[i].getDescription() + "\n";
                }
            }
            return "";
        }
    }
}
