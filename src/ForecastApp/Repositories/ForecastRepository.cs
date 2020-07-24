using ForecastApp.Models.OpenWeatherMap;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using ForecastApp.Config;
using ForecastApp.Repositories;




namespace ForecastApp.Repositories
{
    public class ForecastRepository : IForecastRepository
    {
        WeatherResponse IForecastRepository.GetForecast(string city)
        {
            string IDOWeather = Constants.OPEN_WEATHER_APPID;

            var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={IDOWeather}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);

                return content.ToObject<WeatherResponse>();
            }
            else
            {
                return null;
            }

        }
    }
}