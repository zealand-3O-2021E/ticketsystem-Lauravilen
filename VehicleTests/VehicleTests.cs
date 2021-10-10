using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace VehicleTests
{
    [TestClass]
    public class VehicleTests
    {
        DateTime date = new DateTime(2021, 09, 20);
        private string standardLicense = "YB87331";
        private string sixCharacterLicense = "CX4377";
        private string sevenCharacterLicense = "CX43772";
        private string eightCharacterLicense = "CX437721";

        [TestMethod]
        public void DateTest()
        {
            Car car = new Car(standardLicense, date);
            Assert.AreEqual(new DateTime(2021, 09, 20), car.Date);
        }

        [TestMethod]
        public void ValidLicenseTest()
        {
            var mock = new Mock<Vehicle>(sixCharacterLicense, date);
            var vehicle = mock.Object;

            Assert.AreEqual(sixCharacterLicense, vehicle.LicensePlate);
        }

        [TestMethod]
        public void ValidLicense_Boundary_Test()
        {
            var mock = new Mock<Vehicle>(sevenCharacterLicense, date);
            var vehicle = mock.Object;

            Assert.AreEqual(sevenCharacterLicense, vehicle.LicensePlate);
        }

        [TestMethod]
        public void InvalidLicense_LicenseTooLong_Test()
        {
            var exception = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car(eightCharacterLicense, date));
            Assert.AreEqual("License plate cannot be longer than 7 characters", exception.Message);
        }

        [TestMethod]
        public void InvalidLicense_LicenseNull_Test()
        {
            Assert.ThrowsException<NullReferenceException>(() => new Car(null, date));
        }
    }
}
