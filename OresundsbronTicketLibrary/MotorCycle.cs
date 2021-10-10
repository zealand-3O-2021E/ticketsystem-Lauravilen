using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundsbronTicketLibrary
{
    public class MotorCycle : ClassLibraryTicketSystem.MotorCycle
    {
        public MotorCycle(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }

        public MotorCycle(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
        }

        public override double Price()
        {
            if (Brobizz == true)
            {
                return 73;
            }

            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
