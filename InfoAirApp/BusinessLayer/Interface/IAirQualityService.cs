using BusinessLayer.Model.AirPollution;

namespace BusinessLayer.Interface
{
    public interface IAirQualityService
    {
        string GetAirQualityIndex(string latitude, string longitude);
        AirPollutionData GetAirPollution(string latitude, string longitude);
    }
}
