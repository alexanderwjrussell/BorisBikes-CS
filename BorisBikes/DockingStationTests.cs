using System;
using NUnit.Framework;

namespace BorisBikes
{
    [TestFixture]
    public class DockingStationTests
    {
        [Test]
        public void Should_BeAbleTo_ReleaseBike()
        {
            var dockingStation = new DockingStation(1);
            var bike = new Bike();

            dockingStation.Dock(bike, 0);
         
            Assert.That(dockingStation.ReleaseBike(0), Is.Not.Null);
        }

        [Test]
        public void Should_OnlyRealeaseBike_IfOneExistsInDockingStation()
        {
            var dockingStation = new DockingStation(0);

            Assert.Throws<Exception>(() => dockingStation.ReleaseBike(1));
        }

        [Test]
        public void Should_OnlyRealeaseBike_IfOneAvailableInTheSpace()
        {
            var dockingStation = new DockingStation(1);
            var bike = new Bike();

            dockingStation.Dock(bike, 0);
            dockingStation.ReleaseBike(0);

            Assert.Throws<Exception>(() => dockingStation.ReleaseBike(0));
        }

        [Test]
        public void Should_ReleaseTheSameBikeWhichOccupiesTheSpace()
        {
            var dockingStation = new DockingStation(1);
            var bike = new Bike();

            dockingStation.Dock(bike, 0);
            var bike2 = dockingStation.ReleaseBike(0);

            Assert.That(bike, Is.EqualTo(bike2));
        }

        [Test]
        public void Should_BeAbleTo_DockABike()
        {
            var dockingStation = new DockingStation(2);
            var bike = new Bike();

            dockingStation.Dock(bike, 1);

            Assert.That(dockingStation.BikeStore, Is.Not.Empty);
        }

        [Test]
        public void Should_NotBeAbleTo_DockInAnOccupiedSpace()
        {
            var dockingStation = new DockingStation(2);
            var bike = new Bike();

            dockingStation.Dock(bike, 1);

            Assert.Throws<Exception>(() => dockingStation.Dock(bike, 1));
        }

        [Test]
        public void Should_BeAbleTo_ReportABikeAsBroken()
        {
            var dockingStation = new DockingStation(2);
            var bike = new Bike();
            
            dockingStation.Dock(bike, 1);
            dockingStation.ReportBroken(1);

            Assert.That(bike.Working, Is.False);
        }

        [Test]
        public void Should_BeAbleTo_RepairBike()
        {
            var maintenance = new Maintenance();
            var dockingStation = new DockingStation(2);
            var bike = new Bike();

            dockingStation.Dock(bike, 1);
            dockingStation.ReportBroken(1);

            maintenance.Repair(bike);

            Assert.That(bike.Working, Is.True); 
        }

        [Test]
        public void Should_NotBeAbleToDock_ANullBike()
        {
            var dockingStation = new DockingStation(1);

            Assert.Throws<Exception>(() => dockingStation.Dock(null, 0));
        }

        [Test]

        public void Should_NotBeAbleToDock_OotsideOfLocation()
        {
            var dockingStation = new DockingStation(1);
            var bike = new Bike();

            Assert.Throws<Exception>(() => dockingStation.Dock(bike, 1));
        }
    }
}
