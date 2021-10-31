using Newtonsoft.Json;
using System;

namespace BusinessLayer.Model.AirPollution
{
    [Serializable]
    public class AirPollution
    {
        [JsonProperty("DateTimeStamp")]
        public string DateTimeStamp { get; set; }

        [JsonProperty("AQI")]
        public AirQualityIndex AQI { get; set; }

        [JsonProperty("Components")]
        public AirPollutionComponents Components { get; set; }
    }
    public class AirQualityIndex
    {
        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}
