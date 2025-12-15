using System;
using System.Collections.Generic;
using System.Text;

namespace SomethingForFun
{
    public class Pizza : IFoodStuff
    {
        string name;
        int price;
        public Pizza(string name, int price) {
            this.name = name;
            this.price = price;
        }
        public string Order()
        {
            return name + " costs " + price;
        }
    }
}
