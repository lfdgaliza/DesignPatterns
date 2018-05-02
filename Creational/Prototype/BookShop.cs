using System;
using System.Collections.Generic;

namespace Prototype
{
    public class BookShop : ICloneable<BookShop>
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public override string ToString() => $"BookShop [Bame={Name}, Books={String.Join(',', Books)}]";

        public BookShop(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }

        #region Prototype
        public BookShop DeepClone()
        {
            var clonedBookShop = new BookShop(this.Name);

            foreach (var book in this.Books)
                clonedBookShop.Books.Add(book.DeepClone());

            return clonedBookShop;
        }
        object ICloneable.Clone() => this.MemberwiseClone();
        #endregion
    }
}