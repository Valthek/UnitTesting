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
            Mock<IPlanetaryManeuver>? moq = new();
            moq.Setup(maneuver => maneuver.CalculateHohmanDeltaV(jupiter, venus)).Returns(45);
            moq.SetupAllProperties();
            IPlanetaryManeuver mock = moq.Object;

            mock.CalculateHohmanDeltaV(jupiter, venus);

            moq.Verify(maneuver => maneuver.CalculateHohmanDeltaV(jupiter, venus), Times.Once);
            moq.Verify(maneuver => maneuver.CalculateSMAxis(jupiter, venus), Times.Once);
        }
    }
}
