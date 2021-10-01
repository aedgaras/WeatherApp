using Newtonsoft.Json;
using RestSharp;
using WeatherApp.API.Models;

namespace WeatherApp.API.Handlers
{
    public class WeatherHandler
    {
        public static async Task<CurrentWeather> HandleCurrentWeather()
        {

            var geolocation = GeolocationHandler.HandleVisitorGeolocation().Result;

            var client = new RestClient($"https://community-open-weather-map.p.rapidapi.com/weather?q={geolocation.city}&units=metric");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "e4632e026fmsh22c0771086f2801p1e355djsn8d166deec3dc");
            IRestResponse response = client.Execute(request);

            var currentWeather = JsonConvert.DeserializeObject<CurrentWeatherResponse>(response.Content);

            return new CurrentWeather
            {
                Location = geolocation.city,
                Temparature = currentWeather.main.temp,
                FeelsLike = currentWeather.main.feels_like,
                TemparatureMin = currentWeather.main.temp_min,
                TemparatureMax = currentWeather.main.temp_max,
                Pressure = currentWeather.main.pressure,
                Humidity = currentWeather.main.humidity,
                ShortDescription = currentWeather.weather[0].main,
                Description = currentWeather.weather[0].description,
                IconId = " http://openweathermap.org/img/wn/" + currentWeather.weather[0].icon + "@2x.png"
            };
        }

        public static async Task<MonthlyForecastResponse> Handle30DayForecast()
        {
            var geolocation = GeolocationHandler.HandleVisitorGeolocation().Result;

            var client = new RestClient($"https://community-open-weather-map.p.rapidapi.com/climate/month?q={geolocation.city}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "e4632e026fmsh22c0771086f2801p1e355djsn8d166deec3dc");
            IRestResponse response = client.Execute(request);

            var monthlyForecast = JsonConvert.DeserializeObject<MonthlyForecastResponse>(response.Content);

            return monthlyForecast;
        }

        public static async Task<HourlyForecastResponse> Handle5Day3HourForecast()
        {
            var geolocation = GeolocationHandler.HandleVisitorGeolocation().Result;

            var client = new RestClient($"https://community-open-weather-map.p.rapidapi.com/forecast?q={geolocation.city}&units=metric");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "e4632e026fmsh22c0771086f2801p1e355djsn8d166deec3dc");
            IRestResponse response = client.Execute(request);

            var hourlyForecast = JsonConvert.DeserializeObject<HourlyForecastResponse>(response.Content);

            return hourlyForecast;
        }

        public static async Task<DailyForecastResponse> Handle16DayDailyForecast()
        {
            var geolocation = GeolocationHandler.HandleVisitorGeolocation().Result;

            var client = new RestClient($"https://community-open-weather-map.p.rapidapi.com/forecast/daily?q={geolocation.city}&units=metric");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "e4632e026fmsh22c0771086f2801p1e355djsn8d166deec3dc");
            IRestResponse response = client.Execute(request);

            var dailyWeather = JsonConvert.DeserializeObject<DailyForecastResponse>(response.Content);

            return dailyWeather;
        }
    }
}
