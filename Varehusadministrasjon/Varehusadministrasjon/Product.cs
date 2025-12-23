using System;
using System.Collections.Generic;
using System.Text;

namespace Varehusadministrasjon
{
    internal class Product
    {
        public string code {  get; private set; }
        public string name { get; private set; }
        public int price { get; private set; }
        public Product(string code, string name, int price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }
    }
}
