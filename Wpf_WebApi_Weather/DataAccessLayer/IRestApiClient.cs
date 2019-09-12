using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_WebApi_Weather.Models;

namespace Wpf_WebApi_Weather.DataAccessLayer
{
    interface IRestApiClient
    {
        WeatherData ExecuteRequest(RestClient restClient, IRestRequest request);
    }
}
