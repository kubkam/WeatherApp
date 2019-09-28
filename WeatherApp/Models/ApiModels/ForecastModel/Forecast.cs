using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.ApiModels.ForecastModel
{
    public class Forecast
    {
        public MainForecast main { get; set; }

        public List<Weather> weather { get; set; }

        public Clouds clouds { get; set; }

        public Wind wind { get; set; }

        public Rain rain { get; set; }

        public Snow snow { get; set; }

        public string dt_txt { get; set; }

    }
}
