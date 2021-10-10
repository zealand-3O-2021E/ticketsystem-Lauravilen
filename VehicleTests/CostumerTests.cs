using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundsbronTicketLibrary;
using StoreBaeltTicketLibrary;
using Car = StoreBaeltTicketLibrary.Car;
using MotorCycle = ClassLibraryTicketSystem.MotorCycle;

namespace VehicleTests
{
    [TestClass]
    public class CostumerTests
    {
        private List<Vehicle> trips = new List<Vehicle>()
        {
            new StoreBaeltTicketLibrary.Car("HJ88791", new DateTime(2020, 01, 06), Car.Day.Monday),
            new OresundsbronTicketLibrary.Car("GI73551", new DateTime(2021, 04, 30)),
            new StoreBaeltTicketLibrary.Car("GZ45923", new DateTime(2021, 06, 01), Car.Day.Tuesday, true),
            new OresundsbronTicketLibrary.Car("UU88312", new DateTime(2021, 06, 15), true),
            new StoreBaeltTicketLibrary.Car("CX43772", new DateTime(2021, 07, 11), Car.Day.Sunday),
            new StoreBaeltTicketLibrary.Car("GI73551", new DateTime(2021, 07, 20), Car.Day.Saturday, true),
            new MotorCycle("VB89662", new DateTime(2021, 07, 25)),
            new OresundsbronTicketLibrary.MotorCycle("YB87331", new DateTime(2021, 08, 17)),
            new MotorCycle("VB89662", new DateTime(2021, 09, 03), true),
            new OresundsbronTicketLibrary.MotorCycle("YB87331", new DateTime(2021, 09, 23), true)

            //240, 410, 228, 163, 192, 182.4, 125, 210, 118.75, 73
        };

        [TestMethod]
        public void TripCollection_VehicleTypeTest()
        {
            List<string> expectedList = new List<string>() {"Car", "Oresund Car", "Car", "Oresund Car", "Car", "Car", "MC", "Oresund MC", "MC", "Oresund MC"};
            Costumer costumer = new Costumer(trips);
            List<string> actualList = new List<string>();

            foreach (var trip in costumer.Trips)
            {
                actualList.Add(trip.VehicleType());
            }
            
            CollectionAssert.AreEquivalent(expectedList, actualList);

        }

        [TestMethod]
        public void TripCollection_PriceTest()
        {
            List<double> expectedList = new List<double>() { 240, 410, 228, 163, 192, 182.4, 125, 210, 118.75, 73 };
            Costumer costumer = new Costumer(trips);
            List<double> actualList = new List<double>();

            foreach (var trip in costumer.Trips)
            {
                actualList.Add(trip.Price());
            }

        }

        [TestMethod]
        public void TripCollection_AddTest()
        {
            Costumer costumer = new Costumer();

            int emptyList = costumer.Trips.Count();

            costumer.AddTripToList(new StoreBaeltTicketLibrary.Car("HJ88791", new DateTime(2020, 01, 06), Car.Day.Monday));

            Assert.AreEqual(0, emptyList);
            Assert.AreEqual(1, costumer.Trips.Count());
        }

    }
}
