

using System.ComponentModel.Design;

namespace OwnProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dinosaur TRex = new Dinosaur("Tyrannosaurus Rex", "Stor kjøtteter med største bitekraften til en dinosaur og er tyngste kjøttetende dinosauren","Theropod");
            DinoFacts.addDino(TRex);
            Dinosaur Diplodocus = new Dinosaur("Diplodocus", "Stor planteter som potensielt veltet trær med kroppsvekten sin og var så store at nesten ingen jaktet på dem", "Sauropod");
            DinoFacts.addDino(Diplodocus);
            Dinosaur Therizinosaurus = new Dinosaur("Therizinosaurus", "Stor planteter med lange klør som ble brukt til selvvforvar og til å kutte angripere", "Theropod");
            DinoFacts.addDino(Therizinosaurus);
            Dinosaur Velociraptor = new Dinosaur("Velociraptor", "Liten kjøtteter med stor klo på den ene delen av foten som hjalp med å ta stort bytte", "Theropod");
            DinoFacts.addDino(Therizinosaurus);
            Dinosaur Archeopterix = new Dinosaur("Archeopterix", "Liten liten kjøtteter som kunne fly som en moderne fugl", "Theropod");
            DinoFacts.addDino(Archeopterix);
            while (true)
            {
                Console.WriteLine("Finn ut fakta om dinosaur med en indeks skriv menu for å få listen skrevet opp");
                string index = Console.ReadLine();
                index = index.ToLower();
                bool notValid = false;
                if (index == "theropod")
                {
                    Console.WriteLine(DinoFacts.getAllTheropods());
                }
                else if (index == "meny")
                {
                    Console.WriteLine(DinoFacts.getMenu());
                }
                else if(index == "hjelp")
                {
                    Console.WriteLine(DinoFacts.GetHelp());
                }
                else if (index == "")
                {
                    Console.WriteLine("Bruk indeks\n");
                    return;
                }
                for (int i = 0; i < index.Length; i++)
                {
                    if (!"123456789".Contains(index[i])) ;
                    {
                        notValid= true;
                    }
                };
                if (!notValid)
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
    }
}
