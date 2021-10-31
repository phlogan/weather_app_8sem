using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Model.AirPollution
{
    [Serializable]
    public class AirPollutionData
    {
        [JsonProperty("Coordinates")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("Data")]
        public List<AirPollution> Data { get; set; }
    }
}
