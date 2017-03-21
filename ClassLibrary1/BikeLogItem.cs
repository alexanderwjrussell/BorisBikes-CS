using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace BorisBikes
{
  public class BikeLogItem : IGetTime
    {
        public Guid id { get; private set; }
        public string ReleaseTime { get; private set; }
        public string DockTime { get; private set; }
        public int Duration { get; private set; }

        public BikeLogItem()
        {
            ReleaseTime = null;
            DockTime = null;
            Duration = 0;
        }

        public void GetBikeId(Bike bike)
        {
            id = bike.id;
        }

        public void GetDockTime()
        {
            DockTime = GetTime().ToString("HH:mm");
        }

        public void GetReleaseTime()
        {
            ReleaseTime = GetTime().ToString("HH:mm");
        }

        public DateTime GetTime()
        {
            return DateTime.Now;
        }

        public void CalculateDuration(string ReleaseTime, string DockTime)
        {
            Duration = 0;
        } 
    }
}
