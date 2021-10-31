using Newtonsoft.Json;
using System;

namespace BusinessLayer.Model.Weather
{
    [Serializable]
    public class ApiWeatherWind
    {
        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("degrees")]
        public string Degrees { get; set; }
    }
}
