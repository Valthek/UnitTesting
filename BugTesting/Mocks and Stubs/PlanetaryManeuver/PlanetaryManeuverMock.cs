using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAPI.Classes;

namespace Tests.Mocks_and_Stubs.PlanetaryManeuver
{
    public class PlanetaryManeuverMock
    {

        Planet jupiter = new Planet();
        Planet venus = new Planet();

        [Fact]
        public void CalculateSMAxisIsCalledOnce()
        {
          
        }
    }
}
