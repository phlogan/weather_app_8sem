using Newtonsoft.Json;
using System;

namespace BusinessLayer.Model.Weather.Forecast
{
    [Serializable]
    public class ApiWeatherForecastCity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("Coordinates")]
        public Coordinates Coordinates { get; set; }
    }
}
