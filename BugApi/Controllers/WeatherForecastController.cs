using Microsoft.AspNetCore.Mvc;
using TestingAPI.Classes;
using TestingAPI.Classes;

namespace TestingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private PlanetGenerator weatherGenerator;

        public WeatherForecastController()
        {
            this.weatherGenerator = new PlanetGenerator();
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Planet> GetWeather()
        {
            return null;
        }

    }
}