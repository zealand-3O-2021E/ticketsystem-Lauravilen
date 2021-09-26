using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;

namespace VehicleTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void YearMonthDay_DateTest()
        {
            Car car = new Car("CX437721", new DateTime(2021, 09, 02));
            Assert.AreEqual(new DateTime(2021, 09, 02), car.Date);
        }

        // [TestMethod]
        // public void HourMinuteSecond_Date_FailTest()
        // {
        //     Car car = new Car("CX437721", new DateTime(2021, 09, 02, 13, 06, 23));
        //     Assert.AreNotEqual(new DateTime(2021, 09, 02), car.Date);
        // }
        //
        // [TestMethod]
        // public void HourMinuteSecond_Date_SuccessTest()
        // {
        //     Car car = new Car("CX437721", new DateTime(2021, 09, 02, 13, 06, 23));
        //     Assert.AreEqual(new DateTime(2021, 09, 02, 13, 06, 23), car.Date);
        // }

        [TestMethod]
        public void LicenseTest()
        {
            DateTime date = new DateTime(2021, 09, 20);
            Car car = new Car("CX437721", date);

            Assert.AreEqual("CX437721", car.LicensePlate);
        }

        [TestMethod]
        public void PriceTest()
        {
            DateTime date = new DateTime(2021, 09, 20);
            Car car = new Car("CX437721", date);

            Assert.AreEqual(240, car.Price());
        }

        [TestMethod]
        public void TypeTest()
        {
            DateTime date = new DateTime(2021, 09, 20);
            Car car = new Car("CX437721", date);

            Assert.AreEqual("Car", car.VehicleType());
        }

    }
}
