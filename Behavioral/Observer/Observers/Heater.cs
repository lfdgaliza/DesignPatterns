using System;
using Observer;

namespace Observers
{
    public class Heater : IObserver<int>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(int temperature)
        {
            var shouldTurnOn = temperature < Constants.IdealTemperature;
            Console.WriteLine($"Heater {(shouldTurnOn ? "on" : "off")}");
        }
    }
}