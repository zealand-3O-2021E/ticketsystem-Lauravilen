using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MotorCycle : Vehicle
    {
        private double ticketPrice = 125;
        public MotorCycle(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            TicketPrice = ticketPrice;
            Brobizz = false;
        }

        public MotorCycle(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
            TicketPrice = ticketPrice;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
