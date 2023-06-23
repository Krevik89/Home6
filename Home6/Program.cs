using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList myBooks = new BookList();

            // добавляем книги в список
            myBooks.Add(new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger" });
            myBooks.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee" });
            myBooks.Add(new Book { Title = "1984", Author = "George Orwell" });
            
            // удаляем книгу из списка
            myBooks.Remove(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee" });

            // проверяем наличие книги в списке
            Console.WriteLine(myBooks.Contains(new Book { Title = "1984", Author = "George Orwell" })); 
            Console.WriteLine(myBooks.Contains(new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" })); 

            // получаем книгу по индексу
            Console.WriteLine(myBooks[0]); // The Catcher in the Rye by J.D. Salinger
        }
    }
    
}
