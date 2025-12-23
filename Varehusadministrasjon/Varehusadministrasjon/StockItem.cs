using System;
using System.Collections.Generic;
using System.Text;

namespace Varehusadministrasjon
{
    internal class StockItem
    {
        public Product product {  get; set; }
        public int stockNumber { get; set; }
        public StockItem(Product product, int stocknumber) {
        
            this.product = product;
            this.stockNumber = stocknumber;
        }

    }
}
