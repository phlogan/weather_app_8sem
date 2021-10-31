using Newtonsoft.Json;
using System.Collections.Generic;

namespace BusinessLayer.Model.Weather
{
    public class ApiCurrentWeatherData
    {
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coordinates")]
        public ApiCoordinates Coordinates { get; set; }

        [JsonProperty("weather")]
        public List<ApiWeather> Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("detail")]
        public ApiWeatherDetailed Detail { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("wind")]
        public ApiWeatherWind Wind { get; set; }

        [JsonProperty("clouds")]
        public string Clouds { get; set; }
    }
}
