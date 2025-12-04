using System;
using System.Collections.Generic;
using System.Text;

namespace ThisAndBase
{
    internal class Food : Consumable
    {
        private string name;
        private int price;
        public Food(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public Food() : this("test", 25){
        }
        public string GetName()
        {
            return name;
        }
        public int GetPrice() {
            return price;
        }
    }
}
