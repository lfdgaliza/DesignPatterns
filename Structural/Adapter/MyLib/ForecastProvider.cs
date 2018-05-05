namespace Adapter.MyLib
{
    public class ForecastProvider : IForecastProvider
    {
        public string GetCurrentForecast()
            => "Current forecast provided by my lib";
    }
}