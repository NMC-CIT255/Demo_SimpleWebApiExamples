using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Wpf_WebApi_Weather.Models;

namespace Wpf_WebApi_Weather.DataAccessLayer
{
    public static class GetWeatherInfo
    {
        /// <summary>
        /// get weather data using longitude and latitude
        /// </summary>
        /// <param name="lon">longitude</param>
        /// <param name="lat">latitude</param>
        /// <returns>weather data</returns>
        public static WeatherData ByLatitudeLongitude(LocationCoordinates locationCoordinates)
        {
            var restClient = new RestClient();
            restClient.BaseUrl = new Uri(ApiAccess.OPEN_WEATHER_MAP_BASE_URL);

            var request = new RestRequest("weather", Method.GET);
            request.AddParameter("appid", ApiAccess.OPEN_WEATHER_MAP_KEY);
            request.AddParameter("lon", locationCoordinates.Longitude);
            request.AddParameter("lat", locationCoordinates.Latitude);

            RestApiClientSync syncRestClient = new RestApiClientSync();
            WeatherData weatherData = syncRestClient.ExecuteRequest(restClient, request);

            return weatherData;
        }

        /// <summary>
        /// get weather data using zip code
        /// </summary>
        /// <param name="zipCode">zip code</param>
        /// <returns>weather data</returns>
        public static WeatherData ByZipCode(int zipCode)
        {
            var restClient = new RestClient();
            restClient.BaseUrl = new Uri(ApiAccess.OPEN_WEATHER_MAP_BASE_URL);

            var request = new RestRequest("weather", Method.GET);
            request.AddParameter("appid", ApiAccess.OPEN_WEATHER_MAP_KEY);
            request.AddParameter("zip", zipCode);

            RestApiClientSync syncRestClient = new RestApiClientSync();
            WeatherData weatherData = syncRestClient.ExecuteRequest(restClient, request);

            return weatherData;
        }
    }
}
