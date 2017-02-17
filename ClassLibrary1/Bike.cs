using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisBikes
{
    public class Bike
    {
        public bool Working { get; private set; }

        public Bike()
        {
            Working = true;
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
