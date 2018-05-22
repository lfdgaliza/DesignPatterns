using System;
using Observer;

namespace Observers
{
    public class AirConditioner : IObserver<int>
    {
        public void OnCompleted()
        {
            // You can call this inside your provider if you want to do something
            // after all
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            // You can call this from your provider just in case you want to do
            // something if something went wrong during the update.
            throw new NotImplementedException();
        }

        public void OnNext(int temperature)
        {
            var shouldTurnOn = temperature > Constants.IdealTemperature;
            Console.WriteLine($"Air Conditioner {(shouldTurnOn ? "on" : "off")}");
        }
    }
}