using System;

namespace BorisBikes
{
    public class Bike
    {
        public bool Working { get; private set; }
        public Guid id { get; private set; }

        public Bike()
        {
            Working = true;
            id = Guid.NewGuid();
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
