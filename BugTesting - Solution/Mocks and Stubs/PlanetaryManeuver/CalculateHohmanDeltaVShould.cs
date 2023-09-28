using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAPI.Classes;

namespace Tests.Mocks_and_Stubs
{
    public class CalculateHohmanDeltaVShould
    {
        [Fact]
        public void Return2forEarthAndMars()
        {
            Planet earth = new Planet();
            Planet mars = new Planet();

            Mock<IPlanetaryManeuver>? moqObject = new();

            moqObject.Setup(super => super.CalculateHohmanDeltaV(earth, mars)).Returns(2);

            IPlanetaryManeuver stub = moqObject.Object;
            Assert.Equal(2, stub.CalculateHohmanDeltaV(earth, mars));

        }
    }
}
