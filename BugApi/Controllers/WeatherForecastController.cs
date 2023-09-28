using Microsoft.AspNetCore.Mvc;
using TestingAPI.Classes;
using TestingAPI.Classes.Interface;

namespace BugApi.Controllers
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
            return Enumerable.Range(1, 5).Select(index => weatherGenerator.GeneratePlanet())
            .ToArray();
        }

    }
}