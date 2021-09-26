using System;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        /// <summary>
        /// Gets or sets the license plate of the car
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Gets or sets the date of crossing
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Represents a car and contains relevant information about the car, for the ticketing system
        /// </summary>
        /// <param name="licensePlate">The car's license plate</param>
        /// <param name="date">The date of crossing</param>
        public Car(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Returns the ticket price as a double
        /// </summary>
        /// <returns>240</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the car's vehicle type
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
