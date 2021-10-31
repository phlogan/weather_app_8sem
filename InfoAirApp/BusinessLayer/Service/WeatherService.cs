using BusinessLayer.Enum;
using BusinessLayer.Interface;
using BusinessLayer.Model;
using BusinessLayer.Model.Weather;
using BusinessLayer.Model.Weather.Forecast;

namespace BusinessLayer.Service
{
    public class WeatherService : BaseService, IWeatherService
    {
        public WeatherService() : base()
        {
            Path = "weather";
        }

        public ApiCurrentWeatherData GetCurrentWeatherData(string cityName)
        {
            var apiRequest = new ApiRequestData(CompletePath, "currentWeather", cityName);

            return apiRequest.CallApi<ApiCurrentWeatherData>(ApiRequestMethod.GET);
        }

        public ApiCurrentWeatherData GetCurrentWeatherData(string latitude, string longitude)
        {
            var apiRequest = new ApiRequestData(CompletePath, "currentWeather");
            apiRequest.AddQueryParameter("latitude", latitude);
            apiRequest.AddQueryParameter("longitude", longitude);

            return apiRequest.CallApi<ApiCurrentWeatherData>(ApiRequestMethod.GET);
        }

        public ApiWeatherForecast GetWeatherForecast(string latitude, string longitude, int daysToForecast)
        {
            var apiRequest = new ApiRequestData(CompletePath, "forecast");
            apiRequest.AddQueryParameter("latitude", latitude);
            apiRequest.AddQueryParameter("longitude", longitude);
            apiRequest.AddQueryParameter("daysToForecast", daysToForecast.ToString());

            return apiRequest.CallApi<ApiWeatherForecast>(ApiRequestMethod.GET);
        }
    }
}
