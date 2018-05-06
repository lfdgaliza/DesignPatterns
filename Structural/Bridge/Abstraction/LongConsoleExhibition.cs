using System;
using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public class LongConsoleExhibition : ExhibitionBase
    {
        public LongConsoleExhibition(IExhibitionResource exhibitionResource)
            : base(exhibitionResource) { }

        private const string _line = "==========";
        private const string _separator = "-";
        public override void Show()
        {
            Console.WriteLine(_line);

            Console.WriteLine(_exhibitionResource.Name);
            Console.WriteLine(_exhibitionResource.ShortDescription);
            Console.WriteLine(_separator);
            Console.WriteLine(_exhibitionResource.LongDescription);

            Console.WriteLine(_line);
        }
    }
}