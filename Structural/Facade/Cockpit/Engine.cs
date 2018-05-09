using System;

namespace Facade.Cockpit
{
    public class Engine
    {
        public void SetSpeed(double speed)
            => Console.WriteLine($"Speed: {speed}%");
    }
}