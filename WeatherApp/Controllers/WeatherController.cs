using Microsoft.AspNetCore.Mvc;
using WeatherApp.API.Handlers;
using WeatherApp.API.Models;

namespace WeatherApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpGet("currentWeather")]
        public async Task<CurrentWeather> GetCurrentWeatherAsync()
        {
            var weather = WeatherHandler.HandleCurrentWeather().Result;
            return weather;
        }

        [HttpGet("monthlyForecast")]
        public async Task<MonthlyForecastResponse> Get30DayForecastAsync()
        {
            var weather = WeatherHandler.Handle30DayForecast().Result;
            return weather;
        }

        [HttpGet("dailyForecast")]
        public async Task<DailyForecastResponse> Ge16DayDailyForecastAsync()
        {
            var weather = WeatherHandler.Handle16DayDailyForecast().Result;
            return weather;
        }

        [HttpGet("hourlyForecast")]
        public async Task<HourlyForecastResponse> Get5Day3HourForecastAsync()
        {
            var weather = WeatherHandler.Handle5Day3HourForecast().Result;
            return weather;
        }
    }
}
