using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public int EffectiveArrival { get; set; }
        public TimeSpan EstimateDuration { get; set; }
        public Plane Myplane { get; set; }

        public IList<Passenger> Passengers { get; set; }


        public override string ToString()
        {
            return $"Flight ID: {FlightId}, Departure: {Departure}, Destination: {Destination}, " +
                   $"Flight Date: {FlightDate}, Estimated Duration: {EstimateDuration}, " +
                   $"Effective Arrival: {EffectiveArrival}, Plane: {Myplane}, " +
                   $"Passengers Count: {Passengers?.Count ?? 0}";
        }





    }
}
