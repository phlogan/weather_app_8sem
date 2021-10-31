using Newtonsoft.Json;
using System;

namespace BusinessLayer.Model.Weather
{
    [Serializable]
    public class ApiWeatherDetailed
    {
        [JsonProperty("temperature")]
        public decimal Temperature { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("minTemperature")]
        public decimal MinTemperature { get; set; }

        [JsonProperty("maxTemperature")]
        public decimal MaxTemperature { get; set; }
    }
}
