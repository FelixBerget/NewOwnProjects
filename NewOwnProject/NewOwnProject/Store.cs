using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NewOwnProject
{
    internal class Store
    {
        public List<Item> Products { get; set; }

        public Store() { 
            Products = new List<Item>();
        }
        public void AddToList(Item item)
        {
            Products.Add(item); 
        }

        public  string GetProductName(int index)
        {
            if (index < Products.Count)
            {
                return Products[index].Name;
            }
            return string.Empty;
        }

        public string GetProductByIndex(int index)
        {
            if (index < Products.Count)
            {
                return "\n" + Products[index].Name + " " + Products[index].Price + " kr og det er " + Products[index].Stock + " av dem igjen";
            }
            return string.Empty;
        }

        public string GetProductByName(string name)
        {
            int index = 0;
            for(int i = 0; i < Products.Count; i++)
            {
                if (name == Products[i].Name)
                {
                    index = i;
                }
            }
            return "\n" + Products[index].Name + " " + Products[index].Price + " kr og det er " + Products[index].Stock + " av dem igjen";

        }

        public string GetAllItems()
        {
            string ReturnString = string.Empty;
            for (int i = 0; i < Products.Count; i++)
            {
                 ReturnString += "\n" + i + " " + Products[i].Name;
            }
            return ReturnString;
        }

    }
}
