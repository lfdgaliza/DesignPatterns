using System.Collections.Generic;

namespace Prototype
{
    public class BookService
    {
        public List<Book> GetDefaultBooks()
        {
            var books = new List<Book>();
            
            for(var bookNumber = 1; bookNumber <= 20; bookNumber++)
                books.Add(new Book(bookNumber, $"Title {bookNumber}"));
            
            return books;
        }
    }
}