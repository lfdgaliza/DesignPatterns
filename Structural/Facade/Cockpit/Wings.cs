using System;

namespace Facade.Cockpit
{
    public class Wings
    {
        public void DoSomething()
            => Console.WriteLine("Doing something...");

        public void SetSlats(int position)
            => Console.WriteLine($"Configuring slats... {position}°");

        public void SetFlaps(int position)
            => Console.WriteLine($"Configuring flaps... {position}°");
    }
}