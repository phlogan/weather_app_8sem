using BusinessLayer.Model.Weather;
using BusinessLayer.Model.Weather.Forecast;

namespace BusinessLayer.Interface
{
    public interface IWeatherService
    {
        ApiCurrentWeatherData GetCurrentWeatherData(string cityName);
        ApiCurrentWeatherData GetCurrentWeatherData(string latitude, string longitude);
        ApiWeatherForecast GetWeatherForecast(string latitude, string longitude, int daysToForecast);
    }
}
