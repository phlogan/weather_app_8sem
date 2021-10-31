using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Model.Weather.Forecast
{
    [Serializable]
    public class ApiWeatherForecast
    {
        [JsonProperty("City")]
        public ApiWeatherForecastCity City { get; set; }

        [JsonProperty("ForecastedDays")]
        public string ForecastedDays { get; set; }

        [JsonProperty("Days")]
        public List<ApiWeatherForecastItem> Days { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

    }
}
