namespace WeatherApp.Model.ForecastModel
{
    public class City
    {
        public string name { get; set; }
        public Coordinate coord { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

}
