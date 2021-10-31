using Business.Interface;
using Business.Model;
using System.Net.Http;

namespace Business.Service
{
    public class AirQualityService : BaseService, IAirQualityService
    {
        public AirQualityService(string apiController) : base()
        {
            Path = apiController;
        }
        public string GetAirQualityIndex(string latitude, string longitude)
        {
            using (var client = new HttpClient())
            {
                var apiRequest = new ApiRequestData(CompletePath, "index");

                apiRequest.AddQueryParameter("latitude", latitude);
                apiRequest.AddQueryParameter("longitude", longitude);

                return apiRequest.CallApi<string>(Enum.ApiRequestMethod.GET);
            }
        }
    }
}
