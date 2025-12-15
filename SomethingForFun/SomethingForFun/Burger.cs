using SomethingForFun;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodProject
{
    public class Burger : IFoodStuff
    {
        string patties;
        bool hasTomatoes;
        int price;
        public Burger(string patties, bool hasTomatoes, int price) {
            this.patties = patties;
            this.hasTomatoes = hasTomatoes;
            this.price = price;
        }
        public string Order()
        {
            if (hasTomatoes)
            {
                return "burger with " + patties + " patties and with tomatoes costs " + price;
            }
            else
            {
                return "burger with " + patties + " patties and without tomatoes costs " + price;
            }
        }
    }
}
