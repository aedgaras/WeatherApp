namespace WeatherApp.API.Models
{
    public class CurrentWeather
    {
        public string Location { get; set; }
        public float Temparature { get; set; }
        public float FeelsLike { get; set; }
        public float TemparatureMin { get; set; }
        public float TemparatureMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string IconId { get; set; }
    }
}
