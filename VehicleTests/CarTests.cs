using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;

namespace VehicleTests
{
    [TestClass]
    public class CarTests
    {

        [TestMethod]
        public void PriceTest_NoBrobizz()
        {
            DateTime date = new DateTime(2021, 09, 20);
            Car car = new Car("CX43772", date);

            Assert.AreEqual(240, car.Price());
        }

        [TestMethod]
        public void PriceTest_WithBrobizz()
        {
            DateTime date = new DateTime(2021, 09, 20);
            Car car = new Car("CX43772", date, true);

            Assert.AreEqual(228, car.Price(), 0.01);
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
