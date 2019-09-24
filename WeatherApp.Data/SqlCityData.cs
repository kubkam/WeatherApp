using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using WeatherApp.Core;

namespace WeatherApp.Data
{
    public class SqlCityData : IWeatherData
    {
        private readonly CityDbContext _db;

        public SqlCityData(CityDbContext db)
        {
            _db = db;
        }
    }
}
