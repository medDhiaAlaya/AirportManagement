using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boing,
        Airbus
    }
    public class Plane
    {
        //prop
        public int Capacity { get; set; }
        public DateTime ManuFactureDate { get; set; }
        public int PlaneId { get; set;}
        public  PlaneType Type { get; set; }

        // relation
        List<Flight> Flights { get; set; }

        // to string methode 
        public override string ToString()
        {
            return $"Type : {Type}, capacity :{Capacity} ,ManuFactureDate {ManuFactureDate}, id {PlaneId}  ";
        }


        // constructors 
        public Plane() { }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.Capacity = capacity;
            this.ManuFactureDate = date;
            this.Type= pt;

        }






    }
}
