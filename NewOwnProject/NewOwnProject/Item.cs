using System;
using System.Collections.Generic;
using System.Text;

namespace NewOwnProject
{
    internal class Item
    {
        public string Name  { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Item(string newName, int newPrice, int newStock) {
            Name = newName;
            Price = newPrice;
            Stock = newStock;
        }
    }
}
