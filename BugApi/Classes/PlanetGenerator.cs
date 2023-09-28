using TestingAPI.Classes;

namespace TestingAPI.Classes
{
    public class PlanetGenerator
    {
        private static readonly string[] Summaries = new[]
        {
        "Earth", "Mercury", "Mars", "Venus", "Jupiter", "Saturn", "Neptune", "Uranus", "Deimos", "Ceres", "Pluto"
        };

        private Planet planet;

        public PlanetGenerator() { 
            planet = new Planet();
            planet.Temperature = 30;
        }

        public int GeneratePlanetTempInFarenheit()
        {
            return planet.TemperatureF;
        }
    }
}
