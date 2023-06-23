using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()=> $"{Title} by {Author}";
       
    }

    class BookList
    {
        private List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Remove(Book book)
        {
            books.Remove(book);
        }

        public bool Contains(Book book)
        {
            return books.Contains(book);
        }

        public Book this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return books.Count;
            }
        }
    }
}
