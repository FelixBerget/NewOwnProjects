using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteksystem
{
    internal class Book
    {
        public string title { get ; private set; }
        public string author { get; private set; }
        public DateTime releaseDate { get; private set; }
        public Book(string title, string author, DateTime releaseDate)
        {
            this.title = title;
            this.author = author;
            this.releaseDate = releaseDate;
        }

    }
}
