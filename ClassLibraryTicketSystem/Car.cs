using System;

namespace ClassLibraryTicketSystem
{
    public class Car : Vehicle
    {
        private double ticketPrice = 240;
        /// <summary>
        /// Represents a car and the relevant information about the car, for the ticketing system
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            TicketPrice = ticketPrice;
            Brobizz = false;
        }
        /// <summary>
        /// Represents a car and the relevant information about the car for the ticketing system, including information about Brobizz
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizz"></param>
        public Car(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
            TicketPrice = ticketPrice;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
