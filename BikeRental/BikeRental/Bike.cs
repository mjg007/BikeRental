using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRental
{
    public class Bike
    {
        private string BikeType { set; get; }

        public int GetPrice()
        {
            switch (BikeType)
            {
                case "H":
                    return 5;
                case "D":
                    return 20;
                case "W":
                    return 60;
                default:
                    return 0;
            }
        }

        public void SetTypeBike(string typeByke)
        {
            this.BikeType = typeByke;
        }
    }
}
