using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;

namespace VehicleTests
{
    [TestClass]
    public class CarTests
    {

        [TestMethod]
        public void PriceTest()
        {
            DateTime date = new DateTime(2021, 09, 20);
            Car car = new Car("CX43772", date);

            Assert.AreEqual(240, car.Price());
        }

        [TestMethod]
        public void TypeTest()
        {
            DateTime date = new DateTime(2021, 09, 20);
            Car car = new Car("CX43772", date);

            Assert.AreEqual("Car", car.VehicleType());
        }

    }
}
