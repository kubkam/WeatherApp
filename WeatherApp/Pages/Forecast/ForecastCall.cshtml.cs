using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeatherApp.Data;

namespace WeatherApp.Pages.Forecast
{
    public class ForecastCallModel : PageModel
    {
        private readonly IWeatherData _weatherData;
        public IEnumerable<Core.City> Cities { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } = "Warsaw";

        public ForecastCallModel(IWeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public void OnGet()
        {
            if (SearchTerm.Length >= 3)
                Cities = _weatherData.GetWeathersByCity(SearchTerm);
        }
    }
}