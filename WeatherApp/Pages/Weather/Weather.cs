namespace WeatherApp.Pages.Weather
{
    public partial class WeatherModel
    {
        public partial class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
    }
}