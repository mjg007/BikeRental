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
            Bike hourBike = new Bike();
            hourBike.SetTypeBike("H");

            Assert.AreEqual(hourBike.GetPrice(), 5);
        }

        [TestMethod]
        public void CreateDayBike()
        {
            Bike dayBike = new Bike();
            dayBike.SetTypeBike("D");

            Assert.AreEqual(dayBike.GetPrice(), 20);
        }

        [TestMethod]
        public void CreateWeekyBike()
        {
            Bike weekBike = new Bike();
            weekBike.SetTypeBike("W");

            Assert.AreEqual(weekBike.GetPrice(), 60);
        }
    }
}
