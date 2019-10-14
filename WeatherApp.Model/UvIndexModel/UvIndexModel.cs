namespace WeatherApp.Model.UvIndexModel
{
    public class UvIndexModel
    {
        public float lat { get; set; }
        public float lon { get; set; }
        public string date_iso { get; set; }
        public string date { get; set; }
        public float value { get; set; }

        public static string Description(float value)
        {
            if (value < 3.0f)
                return "Low";
            if (value >= 3.0f && value < 6.0f)
                return "Moderate";
            if (value >= 6.0f && value < 8.0f)
                return "High";
            if (value >= 8.0f && value < 11.0f)
                return "Very High";
           
            return "Extreme";
        }
    }
}
