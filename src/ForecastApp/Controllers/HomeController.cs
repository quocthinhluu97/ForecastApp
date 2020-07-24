
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ForecastApp.Repositories;
using ForecastApp.Models;
using ForecastApp.Models.OpenWeatherMap;
using Microsoft.AspNetCore.Mvc;

namespace ForecastApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IForecastRepository _forecastRepository;

        public HomeController(IForecastRepository forecastAppRepo)
        {
            _forecastRepository = forecastAppRepo;
        }

        // GET: ForecastApp/SearchCity
        public IActionResult SearchCity()
        {
            var viewModel = new SearchCity();

            return View(viewModel);
        }

        // POST: ForecastApp/SearchCity
        [HttpPost]
        public IActionResult SearchCity(SearchCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home", new { city = model.CityName });
            }
            else
            {
                return View(model);
            }

        }

        // GET: ForecastApp/City
        public IActionResult Index(string city)
        {
            WeatherResponse weatherResponse = _forecastRepository.GetForecast(city);
            City viewModel = new City();

            Console.WriteLine(weatherResponse);
            if (weatherResponse != null)
            {
                viewModel.Name = weatherResponse.Name;
                viewModel.Humidity = weatherResponse.Main.Humidity;
                viewModel.Pressure = weatherResponse.Main.Pressure;
                viewModel.Temp = weatherResponse.Main.Temp;
                viewModel.Temp_Max = weatherResponse.Main.Temp_Max;
                viewModel.Feels_Like = weatherResponse.Main.Feels_Like;
                viewModel.Temp_Min = weatherResponse.Main.Temp_Min;
                viewModel.Weather = weatherResponse.Weather[0].Main;
                viewModel.Wind_Speed = weatherResponse.Wind.Speed;
                viewModel.Wind_Degree = weatherResponse.Wind.Deg;
                viewModel.Datetime = UnixTimeStampToDatetime(weatherResponse.Dt);
                viewModel.Sunrise = UnixTimeStampToDatetime(weatherResponse.Sys.Sunrise);
                viewModel.Sunset = UnixTimeStampToDatetime(weatherResponse.Sys.Sunset);

            }
            return View(viewModel);
        }

        public static DateTime UnixTimeStampToDatetime(long unixTimeStamp)
        { 
            System.DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(unixTimeStamp).ToLocalTime();

            return dt;
        }
    }

}
