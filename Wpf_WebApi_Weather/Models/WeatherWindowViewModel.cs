using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_WebApi_Weather.Models
{
    public class WeatherWindowViewModel
    {
        public double CurrentTemp { get; set; }
        public double HighTemp { get; set; }
        public double LowTemp { get; set; }
    }
}
