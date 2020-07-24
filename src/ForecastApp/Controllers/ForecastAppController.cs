
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
    public class ForecastAppController : Controller
    {
        private readonly IForecastRepository _forecastRepository;

        public ForecastAppController(IForecastRepository forecastAppRepo)
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
                return RedirectToAction("City", "ForecastApp", new { city = model.CityName });
            }
            else
            {
                return View(model);
            }

        }

        // GET: ForecastApp/City
        public IActionResult City(string city)
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
                viewModel.Weather= weatherResponse.Weather[0].Main;
                viewModel.Wind= weatherResponse.Wind.Speed;
            }
            return View(viewModel);
        }

    }

}
