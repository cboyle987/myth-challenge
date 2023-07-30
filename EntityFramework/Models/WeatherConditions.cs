using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{

    public class WeatherConditions
    {
        public string? Id { get; set; }
        public int TemperatureFahrenheit { get; set; }
        public bool TemperatureFahrenheitSpecified { get; set; }
        public float TemperatureCelsius { get; set; }
        public bool TemperatureCelsiusSpecified { get; set; }
        public int WindSpeedMiles { get; set; }
        public bool WindSpeedMilesSpecified { get; set; }
        public float WindSpeedKilometers { get; set; }
        public bool WindSpeedKilometersSpecified { get; set; }
        public int WindDirection { get; set; }
        public bool WindDirectionSpecified { get; set; }
        public int WeatherType { get; set; }
        public bool WeatherTypeSpecified { get; set; }
        public string? TailWindSpeed { get; set; }
        public int BaseballHomePlateWindDirection { get; set; }
        public bool BaseballHomePlateWindDirectionSpecified { get; set; }
    }

}
