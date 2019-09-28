using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp.Models.ApiModels
{
    public class Rain
    {
        [JsonProperty("1h")]
        public decimal OneHour { get; set; }

        [JsonProperty("3h")]
        public decimal ThreeHour { get; set; }
    }
}
