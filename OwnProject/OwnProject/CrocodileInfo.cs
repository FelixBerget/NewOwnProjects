using System;
using System.Collections.Generic;
using System.Text;

namespace OwnProject
{
    internal class CrocodileInfo
    {
        static List<Crocodilian> Crocodilians = new List<Crocodilian>();

        public static void addCrocodile(Crocodilian croc)
        {
            Crocodilians.Add(croc);
        }
        public static int getListLength()
        {
            return Crocodilians.Count;
        }
        public static string getMenu()
        {
            string returnString = "\n";
            for (int i = 0; i < Crocodilians.Count; i++)
            {
                returnString += "\n Nummmer " + i + " - " + Crocodilians[i].getName() + "\n";
            }
            return returnString;
        }

        public static string GetHelp()
        {

            return "\n For meny skriv (meny), for spesifikke dinosaur typer skriv arttypen f.eks.(theropod), for å søke i beskrivelsen som f.eks. kjøtteter skriv (søk), for å søke direkte etter navn så skriv (navnsøk), og for dinosaur så skriv f.eks. (2)\n";
        }
        public static string getCrocodileInfo(int index)
        {
            if (index > Crocodilians.Count - 1)
            {
                return "\n Indeks eksisterer ikke\n";
            }
            string returnString = "\n " + Crocodilians[index].getName() + "\n " + Crocodilians[index].getType() + " \n Info under\n\n " + Crocodilians[index].getDescription() + " \n " + Crocodilians[index].getLength() + " meter lang potensielt \n " + Crocodilians[index].getWeight() + " tonn tung potensielt \n";
            return returnString;
        }
        public static string getAllOfSource(string type)
        {
            string returnString = "\n";
            string lowerType = type.ToLower();
            for (int i = 0; i < Crocodilians.Count; i++)
            {
                if (Crocodilians[i].getType().ToLower() == lowerType)
                {
                    returnString += "\n Nummmer " + i + " - " + Crocodilians[i].getName() + "\n";
                }
            }
            return returnString;
        }
        public static string searchInDescriptions(string searchWith)
        {
            string returnString = "\n";
            string searchWithLower = searchWith.ToLower();
            for (int i = 0; i < Crocodilians.Count; i++)
            {
                string searchInLower = Crocodilians[i].getDescription().ToLower();
                if (searchInLower.Contains(searchWithLower))
                {
                    returnString += "\n Nummmer " + i + " - " + Crocodilians[i].getName() + "\n";
                }
            }
            return returnString;
        }
        public static string getCrocodilianByName(string name)
        {
            string searchName = name.ToLower();
            string returnString = "";
            for (int i = 0; i < Crocodilians.Count; i++)
            {
                string searchInLower = Crocodilians[i].getName().ToLower();
                if (searchInLower == searchName)
                {
                    return getCrocodileInfo(i);
                }
            }
            return "\n Finner ikke dinosauren \n ";
        }

        public static string getByWeight(string firstWeigth, string secondWeigth)
        {
            string returnString = "";
            double firstWeightInt = Convert.ToDouble(firstWeigth);
            double secondWeightInt = Convert.ToDouble(secondWeigth);
            for (int i = 0; i < Crocodilians.Count; i++)
            {
                if (Convert.ToDouble(Crocodilians[i].getWeight()) < secondWeightInt && Convert.ToDouble(Crocodilians[i].getWeight()) > firstWeightInt)
                {
                    returnString += "\n Nummmer " + i + " - " + Crocodilians[i].getName() + "\n";
                }
            }
            return returnString;

        }

        public static string makeSound(int index)
        {
            if (index > Crocodilians.Count - 1)
            {
                return "\n Indeks eksisterer ikke\n";
            }
            string returnString = "\n " + Crocodilians[index].makeSound() + "\n";
            return returnString;
        }

    }
}
