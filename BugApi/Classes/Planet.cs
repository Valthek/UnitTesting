namespace TestingAPI.Classes
{
    public class Planet
    {
        internal int orbitRadius;

        public int Temperature { get; set; }

        public int TemperatureF => 32 + (int)(Temperature / 0.5556);
        public int Windspeed { get; set;}
        public double Humidity { get; set; }
        public double Precitiptation { get; set; }
        public string Name { get; set; }
        public int Gravity { get; set; }
        public int OrbitalDistance { get; set; }
    }
}
