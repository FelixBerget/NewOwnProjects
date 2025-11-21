

using System.ComponentModel.Design;

namespace OwnProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dinosaur TRex = new Dinosaur("Tyrannosaurus Rex", "Stor kjøtteter med største bitekraften til en dinosaur og er tyngste kjøttetende dinosauren","Theropod");
            DinoFacts.addDino(TRex);
            Dinosaur Diplodocus = new Dinosaur("Diplodocus", "Stor planteeter som potensielt veltet trær med kroppsvekten sin og var så store at nesten ingen jaktet på dem", "Sauropod");
            DinoFacts.addDino(Diplodocus);
            Dinosaur Therizinosaurus = new Dinosaur("Therizinosaurus", "Stor planteter med lange klør som ble brukt til selvvforvar og til å kutte angripere", "Theropod");
            DinoFacts.addDino(Therizinosaurus);
            Dinosaur Velociraptor = new Dinosaur("Velociraptor", "Liten kjøtteter med stor klo på den ene delen av foten som hjalp med å ta stort bytte", "Theropod");
            DinoFacts.addDino(Velociraptor);
            Dinosaur Archeopterix = new Dinosaur("Archeopterix", "Liten liten kjøtteter som kunne fly som en moderne fugl", "Theropod");
            DinoFacts.addDino(Archeopterix);
            Dinosaur Iguanadon = new Dinosaur("Iguanadon", "Stor planteeter som spiser kan lage høy lyd med hornet sitt", "Hadrosaur");
            DinoFacts.addDino(Iguanadon);
            Dinosaur Argentinosaurus = new Dinosaur("Argentinosaurus", "Gigantisk planteeter som var potensielt største landdyret som noensinne har eksistert, levde i flokk", "Sauropod");
            DinoFacts.addDino(Argentinosaurus);
            while (true)
            {
                Console.WriteLine("Finn ut fakta om dinosaur med en indeks, eller finn dem med arttypen, skriv meny for å få listen skrevet opp, skriv hjelp for å få mer hjelp og skriv ingenting for å avslutte");
                string index = Console.ReadLine();
                index = index.ToLower();
                bool notValid = false;
                for (int i = 0; i < index.Length; i++)
                {
                    if (!"123456789".Contains(index[i])) 
                    {
                        notValid = true;
                    }
                }
                ;
                if (index == "theropod" || index == "sauropod" || index == "theropod")
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
                else if(index == "søk")
                {
                    string searchInText = ReadAnotherLine("Søk i beskrivelsene nå");
                    Console.WriteLine(DinoFacts.searchInDescriptions(searchInText));
                }
                else if(index == "navnsøk")
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
