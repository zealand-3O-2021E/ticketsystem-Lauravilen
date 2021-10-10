using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class Car : ClassLibraryTicketSystem.Car
    {
        public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
        public Day Weekday { get; set; }
        public Car(string licenseplate, DateTime date, Day weekday) : base(licenseplate, date)
        {
            Weekday = weekday;
        }

        public Car(string licenseplate, DateTime date, Day weekday, bool brobizz) : base(licenseplate, date, brobizz)
        {
            Weekday = weekday;
        }

        public override double Price()
        {
            double price = TicketPrice;

            if (Weekday == Day.Saturday || Weekday == Day.Sunday)
            {
                price = TicketPrice * 0.8;
            }

            if (Brobizz == true)
            {
                price = price * 0.95;
            }

            return price;
        }
    }
}
