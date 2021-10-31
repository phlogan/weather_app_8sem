using BusinessLayer.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InfoAirApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class APSPresentation : ContentPage
    {
        protected IAirQualityService _airQualityService = DependencyService.Get<IAirQualityService>();
        protected IWeatherService _weatherService = DependencyService.Get<IWeatherService>();

        public APSPresentation()
        {
            InitializeComponent();
            MountLabels();
        }


        public void MountLabels()
        {
            var location = GetLocation().Result;
            
            var aiq = _airQualityService.GetAirQualityIndex(location.Item1, location.Item2);

            AirQualityIndexLevel.Text = aiq;
            switch (Convert.ToInt32(aiq))
            {
                case 1:
                    AirQualityIndexDefinition.Text = "Bom";
                    AirQualityIndexLevel.TextColor = Color.Green;
                    AirQualityIndexDefinition.TextColor = Color.Green;
                    break;
                case 2:
                    AirQualityIndexDefinition.Text = "Razoável";
                    AirQualityIndexLevel.TextColor = Color.MediumSpringGreen;
                    AirQualityIndexDefinition.TextColor = Color.MediumSpringGreen;
                    break;
                case 3:
                    AirQualityIndexDefinition.Text = "Moderado";
                    AirQualityIndexLevel.TextColor = Color.Yellow;
                    AirQualityIndexDefinition.TextColor = Color.Yellow;
                    break;
                case 4:
                    AirQualityIndexDefinition.Text = "Ruim";
                    AirQualityIndexLevel.TextColor = Color.OrangeRed;
                    AirQualityIndexDefinition.TextColor = Color.OrangeRed;
                    break;
                case 5:
                    AirQualityIndexDefinition.Text = "Muito Ruim";
                    AirQualityIndexLevel.TextColor = Color.Purple;
                    AirQualityIndexDefinition.TextColor = Color.Purple;
                    break;
            }

            var weather = _weatherService.GetCurrentWeatherData(location.Item1, location.Item2);

            CompleteLocation.Text = weather.Name;
            CelsiusDegrees.Text = Math.Floor(weather.Detail.Temperature) + "°C";
            WeatherDefinition.Text = weather.Weather.FirstOrDefault().Description;
            MinTemperature.Text = "Mínima: " + Math.Floor(weather.Detail.MinTemperature) + "°C";
            MaxTemperature.Text = "Máxima: " + Math.Floor(weather.Detail.MaxTemperature) + "°C";
        }

        private static async Task<Tuple<string, string>> GetLocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                return new Tuple<string, string>(location.Latitude.ToString(), location.Longitude.ToString());
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Test Title", "Test", "OK");
                return null;
            }
        }
    }
}