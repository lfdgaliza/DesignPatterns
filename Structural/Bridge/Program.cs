using System;
using Bridge.Abstraction;
using Bridge.Implementor;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = DataHelper.GetBook();
            var person = DataHelper.GetPerson();
            var song = DataHelper.GetSong();

            Console.WriteLine("Short exhibitions:\n---------------------");
            new ShortConsoleExhibition(book).Show();
            new ShortConsoleExhibition(person).Show();
            new ShortConsoleExhibition(song).Show();

            Console.WriteLine("Long exhibitions:\n---------------------");
            new LongConsoleExhibition(book).Show();
            new LongConsoleExhibition(person).Show();
            new LongConsoleExhibition(song).Show();
        }

        static void Separate() => Console.WriteLine();
    }
}
