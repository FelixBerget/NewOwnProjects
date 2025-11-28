using System;
using System.Collections.Generic;
using System.Text;

namespace NewOwnProject
{
    internal class FreshItem : Item
    {
        public int DaysLeft { get; set; }

        public string Advertisement()
        {
            return this.Name + " er tilgjengelig " + this.DaysLeft + " dager mer!";
        }
    }
}
