﻿using NUnit.Framework;

namespace BorisBikes
{
    [TestFixture]
    public class BikeTests
    {
        [Test]
        public void Should_Have_WorkingStatus()
        {
            var bike = new Bike();

            Assert.That(bike.Working, Is.True);
        }

//        [Test]
//        public void Should_Have_ABikeLogItem()
//        {
//            var bike = new Bike();
//
//            Assert.That(bike.bikeLog, Is.Not.Null);
//        }
    }
}
