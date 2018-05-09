using Bridge.Implementor;
using System;
using System.Linq;

namespace Bridge.Abstraction
{
    public abstract class ExhibitionBase
    {
        protected IExhibitionResource _exhibitionResource;
        public ExhibitionBase(IExhibitionResource exhibitionResource)
        {
            _exhibitionResource = exhibitionResource;
        }
        public abstract void Show();
    }
}