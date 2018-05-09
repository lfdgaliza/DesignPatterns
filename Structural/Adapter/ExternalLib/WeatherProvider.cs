namespace Adapter.ExternalLib
{
    public class WeatherProvider : IWeatherProvider
    {
        public (int id, string forecast) GetCurrentWeather()
            => (1, "Current forecast provided by external lib");
    }
}