using Adapter.ExternalLib;

namespace Adapter.MyLib
{
    public class ExternalLibForecastProviderAdapter : IForecastProvider
    {
        private IWeatherProvider _externalLibForecastProvider;
        public ExternalLibForecastProviderAdapter()
        {
            _externalLibForecastProvider = new WeatherProvider();
        }
        public string GetCurrentForecast()
        {
            var externalLibForecast = _externalLibForecastProvider.GetCurrentWeather();
            return externalLibForecast.forecast;
        }
    }
}