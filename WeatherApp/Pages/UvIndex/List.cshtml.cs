using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeatherApp.Data;

namespace WeatherApp.Pages.UvIndex
{
    public class ListModel : PageModel
    {
        private readonly IWeatherData _weatherData;
        public IEnumerable<Core.City> Cities { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } = "";

        public ListModel(IWeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public void OnGet()
        {
            if (SearchTerm.Length > 3)
                Cities = _weatherData.GetWeathersByCity(SearchTerm);
        }
    }
}