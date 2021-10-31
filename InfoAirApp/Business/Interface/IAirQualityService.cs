namespace Business.Interface
{
    public interface IAirQualityService
    {
        string GetAirQualityIndex(string latitude, string longitude);
    }
}
