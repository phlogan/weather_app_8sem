using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Model.Weather.Forecast
{
    [Serializable]
    public class ApiWeatherForecastItem
    {
        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("Main")]
        public ApiWeatherForecastItemMain Main { get; set; }

        [JsonProperty("Weather")]
        public List<ApiWeather> Weather { get; set; }

        [JsonProperty("Pressure")]
        public string Pressure { get; set; }

        [JsonProperty("DateText")]
        public string DateText { get; set; }
    }
}
