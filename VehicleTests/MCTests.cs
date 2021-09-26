using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VehicleTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void YearMonthDay_DateTest()
        {
            MotorCycle  mc = new MotorCycle("VB896621", new DateTime(2021, 08, 03));
            Assert.AreEqual(new DateTime(2021, 08, 03), mc.Date);
        }

        [TestMethod]
        public void LicenseTest()
        {
            DateTime date = new DateTime(2021, 03, 19);
            MotorCycle mc = new MotorCycle("VB896621", date);

            Assert.AreEqual("VB896621", mc.LicensePlate);
        }

        [TestMethod]
        public void PriceTest()
        {
            DateTime date = new DateTime(2021, 03, 19);
            MotorCycle mc = new MotorCycle("VB896621", date);

            Assert.AreEqual(125, mc.Price());
        }

        [TestMethod]
        public void TypeTest()
        {
            DateTime date = new DateTime(2021, 03, 19);
            MotorCycle mc = new MotorCycle("VB896621", date);

            Assert.AreEqual("MC", mc.VehicleType());
        }

    }
}
