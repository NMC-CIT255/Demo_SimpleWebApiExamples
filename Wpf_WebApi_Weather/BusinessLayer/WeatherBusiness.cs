using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_WebApi_Weather.PresentationLayer;
using Wpf_WebApi_Weather.Models;

namespace Wpf_WebApi_Weather.BusinessLayer
{
    public class WeatherBusiness
    {
        public WeatherBusiness()
        {
            WeatherWindowViewModel weatherWindowViewModel = new WeatherWindowViewModel();

            WeatherWindow weatherWindow = new WeatherWindow();
            weatherWindow.DataContext = weatherWindowViewModel;
            weatherWindow.Show();
        }
    }
}
