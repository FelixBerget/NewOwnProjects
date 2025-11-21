

using System.ComponentModel.Design;

namespace OwnProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dinosaur TRex = new Dinosaur("Tyrannosaurus Rex", "Stor kjøtteter med største bitekraften til en dinosaur og er tyngste kjøttetende dinosauren","Theropod","13", "10");
            DinoFacts.addDino(TRex);
            Dinosaur Diplodocus = new Dinosaur("Diplodocus", "Stor planteeter som potensielt veltet trær med kroppsvekten sin og var så store at nesten ingen jaktet på dem", "Sauropod","24","50");
            DinoFacts.addDino(Diplodocus);
            Dinosaur Therizinosaurus = new Dinosaur("Therizinosaurus", "Stor planteter med lange klør som ble brukt til selvvforvar og til å kutte angripere", "Theropod","9","6");
            DinoFacts.addDino(Therizinosaurus);
            Dinosaur Velociraptor = new Dinosaur("Velociraptor", "Liten kjøtteter med stor klo på den ene delen av foten som hjalp med å ta stort bytte i grupper", "Theropod","1.5","0.1");
            DinoFacts.addDino(Velociraptor);
            Dinosaur Archeopterix = new Dinosaur("Archeopterix", "Liten liten kjøtteter som kunne fly som en moderne fugl, og jaktet småbytte", "Theropod","1","0.03");
            DinoFacts.addDino(Archeopterix);
            Dinosaur Iguanadon = new Dinosaur("Iguanadon", "Stor planteeter kunne lage høy lyd med hornet sitt, den kunne også løpe ganske fort", "Hadrosaur","10","8");
            DinoFacts.addDino(Iguanadon);
            Dinosaur Argentinosaurus = new Dinosaur("Argentinosaurus", "Gigantisk planteeter som var potensielt største landdyret som noensinne har eksistert, levde i flokk", "Sauropod","33","100");
            DinoFacts.addDino(Argentinosaurus);
            while (true)
            {
                Console.WriteLine("Finn ut fakta om dinosaur med en indeks, eller finn dem med arttypen, skriv meny for å få listen skrevet opp, skriv hjelp for å få mer hjelp og skriv ingenting for å avslutte");
                string index = Console.ReadLine();
                index = index.ToLower();
                bool notValid = false;
                for (int i = 0; i < index.Length; i++)
                {
                    if (!"0123456789".Contains(index[i])) 
                    {
                        notValid = true;
                    }
                };
                if (index == "theropod" || index == "sauropod" || index == "hadrosaur")
                {
                    Console.WriteLine(DinoFacts.getAllOfSource(index));
                }
                else if (index == "meny")
                {
                    Console.WriteLine(DinoFacts.getMenu());
                }
                else if (index == "hjelp")
                {
                    Console.WriteLine(DinoFacts.GetHelp());
                }
                else if(index == "mellom vekt")
                {
                    string first = ReadAnotherLine("Nederste vekt");
                    string second = ReadAnotherLine("Øverste vekt");
                    DinoFacts.getByWeight(first, second);

                }
                else if (index == "søk")
                {
                    string searchInText = ReadAnotherLine("Søk i beskrivelsene nå");
                    Console.WriteLine(DinoFacts.searchInDescriptions(searchInText));
                }
                else if (index == "navnsøk")
                {
                    string searchName = ReadAnotherLine("Søk med dinosaur navn");
                    Console.WriteLine(DinoFacts.getDinosaurByName(searchName));
                }
                else if (index == "")
                {
                    Console.WriteLine("Ferdig");
                    return;
                }
                else if (!notValid)
                {
                    int intIndex = Convert.ToInt32(index);
                    Console.WriteLine(DinoFacts.getDinoInfo(intIndex));
                }
                else
                {
                    Console.WriteLine("Inputen din er ikke valid \n"); ;
                }

            }
        }
        public static string ReadAnotherLine(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
