using System;
using Adapter.MyLib;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IForecastProvider forecastProvider = new ForecastProvider();
            DisplayForecast(forecastProvider);

            forecastProvider = new ExternalLibForecastProviderAdapter();
            DisplayForecast(forecastProvider);
        }

        static void DisplayForecast(IForecastProvider forecastProvider)
            => Console.WriteLine(forecastProvider.GetCurrentForecast());
    }
}
