using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    public class Bike
    {

        public Bike(string type)
        {
            switch (type)
            {
                case "H":
                    Price = 5;
                    break;
                case "D":
                    Price = 20;
                    break;
                case "W":
                    Price = 60;
                    break;
                default:
                    Price = 0;
                    break;

            }

            BikeType = type;
        }

        public string BikeType { set; get; }
        public int Price { set; get; }

    }
}
