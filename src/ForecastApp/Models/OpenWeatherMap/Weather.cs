using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ForecastApp.Models.OpenWeatherMap
{
    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icoin { get; set; }


    }
}