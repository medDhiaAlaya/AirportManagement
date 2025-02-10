using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

namespace AM.Core.Services
{
    public interface IFlightService
    {
        public IList<DateTime> GetFlightDates(string destination);
        public IList<Flight> GetFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane plane);

        public int GetWeeklyFlightNumber(DateTime date);
        public  double GetDurationAverage( string destination);
        //public SortFlights
        //public GetThreeOlderTravellers
        //public Ilist<Flight> ShowGroupedFlights();

    }
}
