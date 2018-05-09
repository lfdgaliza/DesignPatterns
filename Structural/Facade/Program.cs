using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var _pilot = new PilotFacade();
            
            _pilot.TakeOffThisAeroplane();

            Console.WriteLine("\nSome random passenger: OMG, what was this sound?");            
        }
    }
}
