using System;
using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public class ShortConsoleExhibition : ExhibitionBase
    {
        public ShortConsoleExhibition(IExhibitionResource exhibitionResource)
            : base(exhibitionResource) { }

        private const string _line = "==========";

        public override void Show()
        {
            Console.WriteLine(_line);

            Console.WriteLine(_exhibitionResource.Name);
            Console.WriteLine(_exhibitionResource.ShortDescription);

            Console.WriteLine(_line);
            Console.WriteLine();
        }
    }
}