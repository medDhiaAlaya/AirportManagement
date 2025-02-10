using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    internal class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public int Salary { get; set; }

        public override string GetPassengerType()
        {
            return base.GetPassengerType() + "I am a Staff ";
        }

        public override string ToString()
        {
            return base.ToString() + $", Function: {Function}, " +
                   $"Employment Date: {EmployementDate.ToShortDateString()}, Salary: {Salary}";
        }
    }
}
