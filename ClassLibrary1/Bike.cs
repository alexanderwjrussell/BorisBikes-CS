using System;

namespace BorisBikes
{
    public class Bike
    {
        public bool Working { get; private set; }
        public Guid id { get; private set; }
        public BikeLogItem bikeLog { get; set; }

        public Bike()
        {
            Working = true;
            id = Guid.NewGuid();
            bikeLog = new BikeLogItem();
        }

        public void BreakBike()
        {
            Working = false;
        }

        public void FixBike()
        {
            Working = true;
        }
    }
}
