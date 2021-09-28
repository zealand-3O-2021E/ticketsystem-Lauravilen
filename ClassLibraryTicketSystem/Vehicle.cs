using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {

        /// <summary>
        /// Gets or sets the license plate of the vehicle
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the date of crossing
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the values true or false, depending on whether the vehicle has a Brobizz or not
        /// </summary>
        public bool Brobizz { get; set; }

        public double TicketPrice { get; set; }

        /// <summary>
        /// An abstract class to represent different vehicles for the ticketing system
        /// </summary>
        /// <param name="licensePlate">The vehicle's license plate</param>
        /// <param name="date">The date of crossing</param>
        protected Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = SetLicensePlate(licensePlate);
            Date = date;
            Brobizz = false;
        }

        protected Vehicle(string licensePlate, DateTime date, bool brobizz)
        {
            LicensePlate = licensePlate;
            Date = date;
            Brobizz = brobizz;
        }

        /// <summary>
        /// Returns the price of the ticket as a double
        /// </summary>
        /// <returns>a double</returns>
        public virtual double Price()
        {
            double price = TicketPrice;
            if (Brobizz == true)
            {
                price = price*0.95;
            }

            return price;
        }

        /// <summary>
        /// Returns the vehicle type
        /// </summary>
        /// <returns>a string</returns>
        public abstract string VehicleType();

        private string SetLicensePlate(string licensePlate)
        {
            if (licensePlate.Length <= 7)
            {
                return licensePlate;
            }
            else
            {
                throw new ArgumentOutOfRangeException("License plate cannot be longer than 7 characters", innerException:null);
            }
        }
    }
}
