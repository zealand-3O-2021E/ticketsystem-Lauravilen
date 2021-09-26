using System;

namespace ClassLibraryTicketSystem
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Represents a car and the relevant information about the car, for the ticketing system
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }
        
        public override double Price()
        {
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
