using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Tests
{
    [TestClass]
    public class PromotionTest
    {
        [TestMethod]
        public void CreatePromotion()
        {
            Promotion promotion = new Promotion();

            Bike hourBike = new Bike("H");
            Bike dayBike = new Bike("D");
            Bike weekBike = new Bike("W");

            promotion.AddBike(hourBike);
            promotion.AddBike(dayBike);
            promotion.AddBike(weekBike);

            Assert.AreEqual(promotion.GetPrice(), 59,5);
        }

        [TestMethod]
        public void CreatePromotionWithArrayOfBikes()
        {
            Promotion promotion = new Promotion();
            List<Bike> bikes = new List<Bike>();

            bikes.Add(new Bike("H"));
            bikes.Add(new Bike("D"));
            bikes.Add(new Bike("W"));

            promotion.AddBikesArray(bikes);

            Assert.AreEqual(promotion.GetPrice(), 59, 5);
        }

        [TestMethod]
        public void CreateBadPromotion()
        {
            Promotion promotion = new Promotion();

            Bike hourBike = new Bike("H");
            Bike dayBike = new Bike("D");

            promotion.AddBike(hourBike);
            promotion.AddBike(dayBike);

            Assert.AreEqual(promotion.GetPrice(), -1);
        }
    }
}
