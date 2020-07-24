using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForecastApp.Models
{
    public class SearchCity
    {
        [Required]
        [RegularExpression("^[a-zA-Z ]+$")]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "City Name")]
        public string CityName { get; set; }
    }
}

