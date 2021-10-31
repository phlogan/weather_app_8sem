using Newtonsoft.Json;
using System;

namespace BusinessLayer.Model.Weather.Forecast
{
    [Serializable]
    public class ApiWeatherForecastItemMain
    {
        [JsonProperty("Temperature")]
        public decimal Temperature { get; set; }

        [JsonProperty("MinTemperature")]
        public decimal MinTemperature { get; set; }

        [JsonProperty("MaxTemperature")]
        public decimal MaxTemperature { get; set; }

        [JsonProperty("Pressure")]
        public string Pressure { get; set; }

        [JsonProperty("SeaLevel")]
        public string SeaLevel { get; set; }

        [JsonProperty("GroundLevel")]
        public string GroundLevel { get; set; }

        [JsonProperty("Humidity")]
        public string Humidity { get; set; }
    }
}
