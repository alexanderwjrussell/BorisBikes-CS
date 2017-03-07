using System;
using System.Net;
using NUnit.Framework;

namespace BorisBikes
{
    [TestFixture]
    public class BikeLogItemTests
    {
        [Test]
        public void Should_BeAbleTo_GetId()
        {
            var bike = new Bike();
            var bikelog = new BikeLogItem();

            var id = bike.id;
            bikelog.GetBikeId(bike);

            Assert.That(bikelog.id, Is.EqualTo(id));
        }


        [Test]
        public void Should_LogBike_DockTime()
        {
            
            var bike = new Bike();
            var dockingStation = new DockingStation(1);

            dockingStation.Dock(bike, 0);
            dockingStation.ReleaseBike(0);

            Assert.That(bike.bikeLog.DockTime, Is.EqualTo(DateTime.Now.ToString("HH:mm")));
        }

        [Test]
        public void Should_LogBike_ReleaseTime()
        {
            var bike = new Bike();
            var dockingStation = new DockingStation(1);

            dockingStation.Dock(bike, 0);
            dockingStation.ReleaseBike(0);

            Assert.That(bike.bikeLog.ReleaseTime, Is.EqualTo(DateTime.Now.ToString("HH:mm"))); 

        }
    }
}
