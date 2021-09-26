using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MotorCycle
    {
        /// <summary>
        /// Gets or sets the license plate of the motorcycle
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Gets or sets the date of crossing
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Represents a motorcycle and contains relevant information about the MC, for the ticketing system
        /// </summary>
        /// <param name="licensePlate">The MC's license plate</param>
        /// <param name="date">The date of crossing</param>
        public MotorCycle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Returns the ticket price as a double
        /// </summary>
        /// <returns>125</returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returns the motorcycle's vehicle type
        /// </summary>
        /// <returns>MC</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
