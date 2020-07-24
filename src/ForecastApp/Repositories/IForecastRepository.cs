using ForecastApp.Models.OpenWeatherMap;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ForecastApp.Repositories
{
    public interface IForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}