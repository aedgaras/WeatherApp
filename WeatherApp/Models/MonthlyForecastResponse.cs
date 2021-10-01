namespace WeatherApp.API.Models
{
    public class MonthlyForecastResponse
    {
        public string cod { get; set; }
        public City city { get; set; }
        public float message { get; set; }
        public List[] list { get; set; }

        public class City
        {
            public int id { get; set; }
            public string name { get; set; }
            public Coord coord { get; set; }
            public string country { get; set; }
        }

        public class Coord
        {
            public float lon { get; set; }
            public float lat { get; set; }
        }

        public class List
        {
            public int dt { get; set; }
            public float humidity { get; set; }
            public float pressure { get; set; }
            public Temp temp { get; set; }
            public float wind_speed { get; set; }
        }

        public class Temp
        {
            public float average { get; set; }
            public float average_max { get; set; }
            public float average_min { get; set; }
            public float record_max { get; set; }
            public float record_min { get; set; }
        }
    }
}
