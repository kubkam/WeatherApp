using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Core
{
    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public Coord coord { get; set; }
    }
}
