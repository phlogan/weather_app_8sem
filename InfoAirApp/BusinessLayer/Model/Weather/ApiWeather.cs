using Newtonsoft.Json;
using System;

namespace BusinessLayer.Model.Weather
{
    [Serializable]
    public class ApiWeather
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iconCode")]
        public string IconCode { get; set; }
    }
}
