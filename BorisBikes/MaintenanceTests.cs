using NUnit.Framework;

namespace BorisBikes
{
    [TestFixture]
    public class MaintenanceTests
    {
        [Test]
        public void Should_BeAbleTo_RepairABike()
        {
            var maintenance = new Maintenance();
            var bike = new Bike();

            bike.BreakBike();
            maintenance.Repair(bike);

            Assert.That(bike.Working, Is.EqualTo(true));    
        }
    }
}
