using System;

namespace Facade.Business
{
    public class Cabin
    {
        public void TurnLights(bool on) 
            => Console.WriteLine($"Turning lights {(on ? "on" : "off")}");
    }
}