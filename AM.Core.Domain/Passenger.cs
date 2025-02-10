using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    internal class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public IList<Flight> flights { get; set; }

        public override string ToString()
        {
            return $"Passenger: {FirstName} {LastName}, Passport: {PassportNumber}, " +
                   $"Email: {EmailAdress}, Birth Date: {BirthDate.ToShortDateString()}, " +
                   $"Phone: {TelNumber}, Flights Count: {flights?.Count ?? 0}";
        }
        // public int Age { get; set; } 
        public int Age
        {
            get
            {
                int age = 0;
                age = DateTime.Now.Year - BirthDate.Year;
                if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                    age--;
                return age;
            }
        }
        public virtual string GetPassengerType()
        {
            return "I am a Passenger ";
        }


        public bool CheckProfile(string firstName,string lastName)
        {
            return firstName.Equals(FirstName) && lastName.Equals(LastName);
        }
        public void GetAge(DateTime birthDate, ref int calculatedAge)
        {

            calculatedAge = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                calculatedAge--;
        }



    }
}
