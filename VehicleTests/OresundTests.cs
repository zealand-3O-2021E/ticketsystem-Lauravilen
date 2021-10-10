using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundsbronTicketLibrary;
using Car = OresundsbronTicketLibrary.Car;

namespace VehicleTests
{
    [TestClass]
    public class OresundTests
    {
        #region CarTests

        [TestMethod]
        public void VehicleTypeTest_Car()
        {
            Car car = new Car("HJ88791", new DateTime(2021, 09, 20));
            Assert.AreEqual("Oresund Car", car.VehicleType());
        }

        [TestMethod]
        public void PriceTest_NoBrobizz_Car()
        {
            Car car = new Car("HJ88791", new DateTime(2021, 09, 20));
            Assert.AreEqual(410, car.Price());

        }

        [TestMethod]
        public void PriceTest_WithBrobizz_Car()
        {
            Car car = new Car("HJ88791", new DateTime(2021, 09, 20), true);
            Assert.AreEqual(161, car.Price());
        }

        #endregion

        #region MCTests

        [TestMethod]
        public void VehicleTypeTest_MC()
        {
            MotorCycle mc = new MotorCycle("GI73551", new DateTime(2021, 09, 02));
            Assert.AreEqual("Oresund MC", mc.VehicleType());
        }

        [TestMethod]
        public void PriceTest_NoBrobizz_MC()
        {
            MotorCycle mc = new MotorCycle("GI73551", new DateTime(2021, 09, 02));
            Assert.AreEqual(210, mc.Price());
        }

        [TestMethod]
        public void PriceTest_WithBrobizz_MC()
        {
            MotorCycle mc = new MotorCycle("GI73551", new DateTime(2021, 09, 02), true);
            Assert.AreEqual(73, mc.Price());
        }

        #endregion
    }
}
