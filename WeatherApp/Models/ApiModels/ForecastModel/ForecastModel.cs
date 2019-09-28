using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.ApiModels.ForecastModel
{
    public class ForecastModel
    {
        public List<Forecast> list { get; set; }

        public City city { get; set; }

    }
}
