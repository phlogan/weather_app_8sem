using BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InfoAirApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirQuality : ContentPage
    {
        protected IAirQualityService _airQualityService = DependencyService.Get<IAirQualityService>();
        public AirQuality()
        {
            InitializeComponent();
            MountLabels();
        }


        public void MountLabels()
        {
            var location = GetLocation().Result;
            var airPollution = _airQualityService.GetAirPollution(location.Item1, location.Item2);
            var data = airPollution.Data.FirstOrDefault();
            var components = data.Components;

            AirPollutionList.ItemsSource = new List<object>
            {
                new
                {
                    Element = "Monóxido de Carbono (CO)",
                    QualityInfo = components.CarbonMonoxide,
                },
                new
                {
                    Element = "Monóxido de Nitrogênio (NO)",
                    QualityInfo = components.NitrogenDioxide,
                },
                new
                {
                    Element = "Dióxido de Nitrogênio (NO2)",
                    QualityInfo = components.NitrogenDioxide,
                },
                new
                {
                    Element = "Ozônio (O3)",
                    QualityInfo = components.Ozone,
                },
                new
                {
                    Element = "Dióxido de Enxofre (SO2)",
                    QualityInfo = components.SulphurDioxide,
                },
                new
                {
                    Element = "Material Particulado Fino (PM2.5)",
                    QualityInfo = components.FineParticleMatter,
                },
                new
                {
                    Element = "Material Particulado (PM10)",
                    QualityInfo = components.CoarseParticleMatter,
                },
                new
                {
                    Element = "Amônia (NH3)",
                    QualityInfo = components.Ammonia,
                },
            };

            Index.Text = data.AQI.Value;
            
            switch (Convert.ToInt32(data.AQI.Value))
            {
                case 1:
                    IndexDescription.Text = "Bom";
                    Index.TextColor = Color.Green;
                    IndexDescription.TextColor = Color.Green;
                    break;
                case 2:
                    IndexDescription.Text = "Razoável";
                    Index.TextColor = Color.Green;
                    IndexDescription.TextColor = Color.Green;
                    break;
                case 3:
                    IndexDescription.Text = "Moderado";
                    Index.TextColor = Color.Yellow;
                    IndexDescription.TextColor = Color.Yellow;
                    break;
                case 4:
                    IndexDescription.Text = "Ruim";
                    Index.TextColor = Color.OrangeRed;
                    IndexDescription.TextColor = Color.OrangeRed;
                    break;
                case 5:
                    IndexDescription.Text = "Muito Ruim";
                    Index.TextColor = Color.Purple;
                    IndexDescription.TextColor = Color.Purple;
                    break;
            }
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