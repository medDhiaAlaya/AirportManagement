using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;


namespace AM.Core.Services
{
    public class FlightService : IFlightService
    {
        public IList<Flight> flights { get; set; }

        //methode GetFlightDates giving distination
        public IList<DateTime> GetFlightDates(string destination)
        {
            
             
                var result= flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();

            return result;

        }
       
        public IList<Flight> GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    return flights.Where(f => f.Destination == filterValue).ToList();
                case "Departure":
                    return flights.Where(f => f.Departure == filterValue).ToList();
                case "FlightDate":
                    return flights.Where(f => f.FlightDate == DateTime.Parse(filterValue)).ToList();
                case "FlightId":
                    return flights.Where(f => f.FlightId == int.Parse(filterValue)).ToList();
                case "EffectiveArrival":
                    return flights.Where(f => f.EffectiveArrival == int.Parse(filterValue)).ToList();
                case "EstimateDuration":
                    return flights.Where(f => f.EstimateDuration == TimeSpan.Parse(filterValue)).ToList();
                case "Plane":
                    return flights.Where(f => f.Myplane == new Plane { PlaneId = int.Parse(filterValue) }).ToList();

                default:
                    throw new ArgumentException("Invalid filter type");
            }
        }
       

        //ShowFlightDetails
        public void ShowFlightDetails(Plane plane)
        {
            var planeFlights = flights.Where(f => f.Myplane.Equals(plane) ).ToList();
            var datesAndDestinations = planeFlights.Select(f => new { f.FlightDate, f.Destination }).ToList();


            Console.Write(datesAndDestinations);

        }

        public int GetWeeklyFlightNumber(DateTime date)
        {
            var weekStart = date.AddDays(-(int)date.DayOfWeek);
            var weekEnd = weekStart.AddDays(6);
            var flightsInWeek = flights.Where(f => f.FlightDate >= weekStart && f.FlightDate <= weekEnd).ToList();
            return flightsInWeek.Count;
        }
        public double GetDurationAverage(string destination)
        {
            var flightsToDestination = flights.Where(f => f.Destination == destination).ToList();
            var average = flightsToDestination.Average(f => f.EstimateDuration.TotalMinutes);
            return average;
        }





    }
}
