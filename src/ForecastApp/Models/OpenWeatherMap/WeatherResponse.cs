using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ForecastApp.Models.OpenWeatherMap
{
    public class WeatherResponse
    {
        public Coordinate Coordinate { get; set; }
        public List<Weather> Weather { get; set; }

        public int Visibility { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public Wind Wind { get; set; }
        public Cloud Cloud { get; set; }
        public Main Main { get; set; }
        public string Name { get; set; }
        public string Base { get; set; }


    }
}