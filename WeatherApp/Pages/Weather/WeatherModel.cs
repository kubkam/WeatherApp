using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace WeatherApp.Pages.Weather
{
    public partial class WeatherModel
    {
        public Coordinate coord { get; set; }

        public List<Weather> weather { get; set; }

        public Main main { get; set; }

        public decimal visibility { get; set; }

        public Wind wind { get; set; }

        public Clouds clouds { get; set; }

        public int dt { get; set; }

        public Sys sys { get; set; }

        public string timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}
