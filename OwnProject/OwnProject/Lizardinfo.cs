using System;
using System.Collections.Generic;
using System.Text;

namespace OwnProject
{
    internal class Lizardinfo
    {
        static List<Lizard> Lizards = new List<Lizard>();
        public static void addDino(Dinosaur dinosaur)
        {
            Lizards.Add(dinosaur);
        }
        public static int getListLength()
        {
            return Lizards.Count;
        }
    }
}
