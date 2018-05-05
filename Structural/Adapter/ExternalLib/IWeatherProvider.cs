namespace Adapter.ExternalLib
{
    public interface IWeatherProvider
    {
         (int id, string forecast) GetCurrentWeather();
    }
}