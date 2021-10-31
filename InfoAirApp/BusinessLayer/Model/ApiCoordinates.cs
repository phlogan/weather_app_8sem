using Newtonsoft.Json;
using System;

namespace BusinessLayer.Model
{
    [Serializable]
    public class ApiCoordinates
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }
}
