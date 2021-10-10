using System;
using ClassLibraryTicketSystem;

namespace OresundsbronTicketLibrary
{
    public class Car : ClassLibraryTicketSystem.Car
    {
        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }

        public Car(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
        }

        public override double Price()
        {
            if (Brobizz == true)
            {
                return 161;
            }

            return 410;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
