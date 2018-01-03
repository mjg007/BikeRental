using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeRental.Tests
{
    [TestClass]
    public class BikeTest
    {
        [TestMethod]
        public void CreateHourBike()
        {
            Bike hourBike = new Bike("H");

            Assert.AreEqual(hourBike.Price, 5);
        }

        [TestMethod]
        public void CreateDayBike()
        {
            Bike dayBike = new Bike("D");

            Assert.AreEqual(dayBike.Price, 20);
        }

        [TestMethod]
        public void CreateWeekyBike()
        {
            Bike weekBike = new Bike("W");

            Assert.AreEqual(weekBike.Price, 60);
        }
    }
}
