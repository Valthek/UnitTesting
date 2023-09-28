using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAPI.Classes;

namespace Tests.ExtractAndOverride
{
    public class PlanetGeneratorExtracted
    {
        private Planet planet;

        public PlanetGeneratorExtracted()
        {
            planet = new Planet();
            planet.Temperature = 30;
        }

        protected virtual int GeneratePlanetTempInFarenheit()
        {
            return planet.TemperatureF;
        }
    }

    public class StubPlanetGeneratorExtracted: PlanetGeneratorExtracted
    {
        protected override int GeneratePlanetTempInFarenheit()
        {
            return 15;
        }
    }
}
