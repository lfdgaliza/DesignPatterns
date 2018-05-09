using System;

namespace Facade.Cockpit
{
    public class Cabin
    {
        public void TurnLights(bool on) 
            => Console.WriteLine($"Turning lights {(on ? "on" : "off")}");
    }
}