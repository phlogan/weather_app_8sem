using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Model.AirPollution
{
    [Serializable]
    public class AirPollutionComponents
    {

        [JsonProperty("CarbonMonoxide")]
        public string CarbonMonoxide { get; set; }

        [JsonProperty("NitrogenMonoxide")]
        public string NitrogenMonoxide { get; set; }

        [JsonProperty("NitrogenDioxide")]
        public string NitrogenDioxide { get; set; }

        [JsonProperty("Ozone")]
        public string Ozone { get; set; }

        [JsonProperty("SulphurDioxide")]
        public string SulphurDioxide { get; set; }

        [JsonProperty("FineParticleMatter")]
        public string FineParticleMatter { get; set; }

        [JsonProperty("CoarseParticleMatter")]
        public string CoarseParticleMatter { get; set; }

        [JsonProperty("Ammonia")]
        public string Ammonia { get; set; }
    }
}
