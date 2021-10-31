using BusinessLayer.Interface;
using BusinessLayer.Service;
using Xamarin.Forms;

namespace InfoAirApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IAirQualityService, AirQualityService>();
            DependencyService.Register<IWeatherService, WeatherService>();
            
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
