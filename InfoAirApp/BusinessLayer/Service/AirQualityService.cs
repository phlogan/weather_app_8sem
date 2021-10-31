using BusinessLayer.Interface;
using BusinessLayer.Model;
using BusinessLayer.Model.AirPollution;
using System.Net.Http;

namespace BusinessLayer.Service
{
    public class AirQualityService : BaseService, IAirQualityService
    {
        public AirQualityService() : base()
        {
            Path = "airQuality";
        }
        public string GetAirQualityIndex(string latitude, string longitude)
        {
            var apiRequest = new ApiRequestData(CompletePath, "index");

            apiRequest.AddQueryParameter("latitude", latitude);
            apiRequest.AddQueryParameter("longitude", longitude);

            return apiRequest.CallApi<string>(Enum.ApiRequestMethod.GET);
        }

        public AirPollutionData GetAirPollution(string latitude, string longitude)
        {
            var apiRequest = new ApiRequestData(CompletePath, "getData");

            apiRequest.AddQueryParameter("latitude", latitude);
            apiRequest.AddQueryParameter("longitude", longitude);

            return apiRequest.CallApi<AirPollutionData>(Enum.ApiRequestMethod.GET);
        }
    }
}
