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

        public void AddBikesArray(List<Bike> bikes)
        {
            foreach (Bike bike in bikes)
            {
                Bikes.Add(bike);
            }
        }

        public double GetPrice()
        {
            if (Bikes.Count > 2 && Bikes.Count < 6)
            {
                int result = 0;
                foreach (Bike bike in Bikes)
                {
                    result += bike.Price;
                }
                return result * 0.7;
            }
            else
            {
                return -1;
            }
        }
    }
}
