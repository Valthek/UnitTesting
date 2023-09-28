using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAPI.Classes;

namespace Tests.Mocks_and_Stubs
{
    internal class PlanetaryManeuverStub : IPlanetaryManeuver
    {
        public bool isSuccess { get ; set; }

        public double CalculateBrachistochroneDeltaV()
        {           
            return 0;
        }

        public double CalculateHohmanDeltaV(Planet source, Planet destination)
        {
            return 5;
        }
    }
}
