using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    public class Promotion
    {
        public Promotion()
        {
            Bikes = new List<Bike>();
        }
        private List<Bike> Bikes { set; get; }

        public void AddBike(Bike bike)
        {
            Bikes.Add(bike);
        }

        public int GetPrice()
        {
            int result = 0;
            foreach (Bike bike in Bikes)
            {
                result += bike.GetPrice();
            }
            return result;
        }
    }
}
