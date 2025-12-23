using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteksystem
{
    internal class Library
    {
        private List<Book> books;
        public Library() {
            books = new List<Book>();
        }

        public void AddBook(string title, string author, DateTime releaseDate)
        {
            Book book = new Book(title, author, releaseDate);
            books.Add(book);
        }
        public void RemoveBook(string bookTitle)
        {
            bookTitle = bookTitle.ToLower();
            books.RemoveAll(x => x.title.ToLower() == bookTitle);
        }

        public Book GetBook(string bookTitle)
        {
            bookTitle = bookTitle.ToLower();
            Book foundBook = books.Find(x => x.title.ToLower() == bookTitle);
            if (foundBook == null) {
                return new Book("","",new DateTime());
            }
            return foundBook;
        }

    }
}
