using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_WebApi_Weather.PresentationLayer;
using Wpf_WebApi_Weather.Models;
using Wpf_WebApi_Weather.DataAccessLayer;

namespace Wpf_WebApi_Weather.BusinessLayer
{
    public class WeatherBusiness
    {
        public WeatherBusiness()
        {
            WeatherWindowViewModel weatherWindowViewModel = new WeatherWindowViewModel();

            //
            // get current weather info
            //
            WeatherData defaultWeatherData = GetDefaultWeatherData();

            WeatherWindow weatherWindow = new WeatherWindow();
            weatherWindow.DataContext = weatherWindowViewModel;
            weatherWindow.Show();
        }

        private WeatherData GetDefaultWeatherData()
        {
            WeatherData defaultWeatherData = new WeatherData();

            LocationInformation defaultLocationInformation = new LocationInformation()
            {
                Name = "Traverse City",
                ZipCode = 49664,
                LocationCoordinates = new LocationCoordinates()
                {
                    Latitude = 44.7631,
                    Longitude = 85.6206
                }
            };

            defaultWeatherData = GetWeatherInfo.ByZipCode(defaultLocationInformation.ZipCode);
            return defaultWeatherData;
        }
    }
}
