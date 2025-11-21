using System;
using System.Collections.Generic;
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
                returnString += "Nummmer" + i + "-" + Dinosaurs[i].getName() + "\n";
            }
            return returnString;
        }

        public static string GetHelp()
        {

            return "For meny skriv (meny) og for indeksen så skriv f.eks. 2\n";
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
                    returnString += "Nummmer" + i + "-" + Dinosaurs[i].getName() + "\n";
                }
            }
            return returnString;
        }
    }
}
