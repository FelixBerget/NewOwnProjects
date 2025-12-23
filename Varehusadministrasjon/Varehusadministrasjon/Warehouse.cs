using System;
using System.Collections.Generic;
using System.Text;

namespace Varehusadministrasjon
{
    internal class Warehouse
    {
        public List<StockItem> StockItems {  get; private set; }

        public Warehouse() { 
            StockItems = new List<StockItem>();
        }
        public void AddToStock(StockItem item)
        {
            StockItems.Add(item);
        }
        public void ChangeItem(string whichItem,int stockNumChange)
        {
            StockItems.Find(x=> x.product.name.ToLower()==whichItem.ToLower()).stockNumber+=stockNumChange;
        }
    }
}
