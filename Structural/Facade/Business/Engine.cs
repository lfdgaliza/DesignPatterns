using System;

namespace Facade.Business
{
    public class Engine
    {
        public void SetSpeed(double speed)
            => Console.WriteLine($"Speed: {speed}%");
    }
}