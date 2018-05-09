using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookService = new BookService();

            var defaultBookShop = new BookShop("Default shop");
            defaultBookShop.Books = new BookService().GetDefaultBooks();

            var places = new string[] { "Adelaide St", "George St", "Stevens St" };
            var bookShops = new List<BookShop>();

            foreach (var place in places)
            {
                var bookShop = defaultBookShop.DeepClone();
                Console.WriteLine(bookShop);
            }
        }
    }
}
