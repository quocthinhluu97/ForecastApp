using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ForecastApp.Models
{
    public class City
    {
        [Display(Name = "City:")]
        public string Name { get; set; }

        [Display(Name = "Temparature:")]
        public float Temp { get; set; }

        [Display(Name = "Feels like:")]
        public float Feels_Like { get; set; }

        [Display(Name = "Maximum Temparature:")]
        public float Temp_Max { get; set; }

        [Display(Name = "Minimum Temparature:")]
        public float Temp_Min { get; set; }

        [Display(Name = "Humidity:")]
        public int Humidity { get; set; }

        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }

        [Display(Name = "Wind Speed:")]
        public float Wind_Speed{ get; set; }

        [Display(Name = "Wind Degress:")]
        public float Wind_Degree{ get; set; }


        [Display(Name = "Weather Condition:")]
        public string Weather{ get; set; }

        [Display(Name= "Datetime")]
        [DataType(DataType.Date)]
        public DateTime Datetime;

        [Display(Name= "Sunrise")]
        [DataType(DataType.Date)]
        public DateTime Sunrise;

        [Display(Name= "Sunset")]
        [DataType(DataType.Date)]
        public DateTime Sunset;
        
    }
}
