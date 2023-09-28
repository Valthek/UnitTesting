using System;
using System.Xml.Linq;

namespace TestingAPI.Classes
{
    public interface IPlanetaryManeuver
    {
        bool isSuccess { get; set; }
        double CalculateHohmanDeltaV(Planet source, Planet destination);
        double CalculateBrachistochroneDeltaV();
        long CalculateSMAxis(Planet source, Planet destination);
    }

    public class PlanetaryManeuver : IPlanetaryManeuver
    {

        public static long astronomicalUnit = 149597870700 ;
        public static long gravitationConstant = 116798853600000000;
        public bool isSuccess { get; set; }
        public double CalculateHohmanDeltaV(Planet source, Planet destination)
        {
                var sourceOrbit = source.orbitRadius * astronomicalUnit;
                var destinationOrbit = destination.orbitRadius * astronomicalUnit;
                var smAxis = CalculateSMAxis(source, destination);

                // Calculate deltaV for Insertion Burn (in m/s)
                var orbitVelocitySource = Math.Sqrt(gravitationConstant / sourceOrbit);
                var velocityI = Math.Sqrt(gravitationConstant * ((2 / sourceOrbit) - (1 / smAxis)));
                var deltaVI = velocityI - orbitVelocitySource;


                // Calculate deltaV for Arrival Burn (in m/s)
                var orbitVelocityDestination = Math.Sqrt(gravitationConstant / destinationOrbit);
                var velocityA = Math.Sqrt(gravitationConstant * ((2 / destinationOrbit) - (1 / smAxis)));
                var deltaVA = velocityA - orbitVelocityDestination;


                // Calculate total deltaV (in m/s)
                var deltaV = Math.Abs(deltaVI) + Math.Abs(deltaVA);
                var hohmanResults = Math.Floor(deltaV) / 1000;
                hohmanResults+=(Math.Floor(deltaVI));
                hohmanResults+=(Math.Floor(deltaVA));

                return hohmanResults;
        }

        public double CalculateBrachistochroneDeltaV()
        {
            throw new NotImplementedException();
        }

        public long CalculateSMAxis(Planet source, Planet destination)
        {
            var sourceOrbit = source.orbitRadius * astronomicalUnit;
            var destinationOrbit = destination.orbitRadius * astronomicalUnit;
            var smAxis = (+sourceOrbit + +destinationOrbit) / 2;
            return smAxis;
        }
    }

}