using System;
using System.Threading;
using Observers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherProvider = new WeatherProvider();

            var heaterUnsubscriber = weatherProvider.Subscribe(new Heater());
            weatherProvider.Subscribe(new AirConditioner());


            weatherProvider.Changed(18);
            
            FakeLatency();
            Console.WriteLine("----");
            weatherProvider.Changed(19);
            
            FakeLatency();
            Console.WriteLine("----");
            weatherProvider.Changed(20);

            FakeLatency();
            Console.WriteLine("---- Heater disposed ----");
            heaterUnsubscriber.Dispose();
            weatherProvider.Changed(17);

        }
        private static void FakeLatency()
        {
            Thread.Sleep(1000);
        }
    }
}
