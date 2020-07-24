using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ForecastApp.Models.OpenWeatherMap
{
    public class Sys
    {
        public float Message {get; set;}
        public int Type {get; set;}
        public long Sunrise {get; set;}
        public long Sunset {get; set;}
        public int Id {get; set;}
        public string Country {get; set;}


    }
}