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

            Bike hourBike = new Bike();
            hourBike.SetTypeBike("H");
            Bike dayBike = new Bike();
            dayBike.SetTypeBike("D");
            Bike weekBike = new Bike();
            weekBike.SetTypeBike("W");

            promotion.AddBike(hourBike);
            promotion.AddBike(dayBike);
            promotion.AddBike(weekBike);

            Assert.AreEqual(promotion.GetPrice(), 59,5);
        }

        [TestMethod]
        public void CreateBadPromotion()
        {
            Promotion promotion = new Promotion();

            Bike hourBike = new Bike();
            hourBike.SetTypeBike("H");
            Bike dayBike = new Bike();
            dayBike.SetTypeBike("D");

            promotion.AddBike(hourBike);
            promotion.AddBike(dayBike);

            Assert.AreEqual(promotion.GetPrice(), -1);
        }
    }
}
