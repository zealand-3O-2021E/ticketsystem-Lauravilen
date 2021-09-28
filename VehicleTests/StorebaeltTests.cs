using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;

namespace VehicleTests
{
    [TestClass]
    public class StorebaeltTests
    {
        [TestMethod]
        public void PriceTest_NoDiscounts()
        {
            Car car = new Car("BN34721", new DateTime(2021, 09, 27), Car.Day.Monday);
            Assert.AreEqual(240, car.Price());
        }

        [TestMethod]
        public void PriceTest_OnlyWeekendDiscount()
        {
            Car car = new Car("BN34721", new DateTime(2021, 09, 25), Car.Day.Saturday);
            Assert.AreEqual(192, car.Price());
        }

        [TestMethod]
        public void PriceTest_WeekendDiscount_Brobizz()
        {
            Car car = new Car("BN34721", new DateTime(2021, 09, 25),Car.Day.Saturday, true);
            Assert.AreEqual(182.4, car.Price(), 0.01);
        }
    }
}
