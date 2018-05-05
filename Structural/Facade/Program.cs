using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var _cockpit = new CockpitFacade();
            
            Console.WriteLine(_cockpit.PrepareForTakeOff());
            Console.WriteLine();
            
            _cockpit.TakeOff();

            Console.WriteLine("\n Some random passenger: OMG, what was this sound?");            
        }
    }
}
