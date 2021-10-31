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
    public partial class Weather : ContentPage
    {
        protected IWeatherService _weatherService = DependencyService.Get<IWeatherService>();
        public Weather()
        {
            InitializeComponent();
            MountLabels();
        }

        public void MountLabels()
        {
            var location = GetLocation().Result;
            var currentWeather = _weatherService.GetCurrentWeatherData(location.Item1, location.Item2);
            var forecast = _weatherService.GetWeatherForecast(location.Item1, location.Item2, 3);

            MainTemperature.Text = Math.Floor(currentWeather.Detail.Temperature).ToString() + "°C";
            MainTemperatureDescription.Text = currentWeather.Weather.FirstOrDefault().Description;

            ForecastList.ItemsSource = forecast.Days.Where(e => DateTime.TryParse(e.DateText, out DateTime date)).Select(e => new
            {
                Temperature = string.Format("{0}: {1}°C", DateTime.Parse(e.DateText).DayOfWeek, Math.Floor(e.Main.Temperature).ToString()),
                Description = string.Format("{0} (Min.: {1} / Max.: {2})", e.Weather.FirstOrDefault().Description, Math.Floor(e.Main.MinTemperature), Math.Floor(e.Main.MaxTemperature))
            }).ToList();
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