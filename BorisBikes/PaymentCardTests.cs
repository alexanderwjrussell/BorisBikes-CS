using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace BorisBikes
{
    [TestFixture]
    class PaymentCardTests
    {
        [Test]
        public void Should_BeAbleTo_InitialiseAPaymentCard()
        {
            var card = new PaymentCard();

            Assert.That(card, Is.Not.Null);
        }

        [Test]
        public void Should_InitialiseACard_WithNoBalance()
        {
            var card = new PaymentCard();

            Assert.That(card.Balance, Is.EqualTo(0));
        }

        [Test]
        public void Should_BeAbleToTopUp_PaymentCard()
        {
            var card = new PaymentCard();

            card.TopUp(10);

            Assert.That(card.Balance, Is.EqualTo(10));
        }

        [Test]
        public void Should_BeAbleTo_MakeAPayment()
        {
            var card = new PaymentCard();

            card.TopUp(10);
            card.MakePayment(10);

            Assert.That(card.Balance, Is.EqualTo(0));
        }

        [Test]
        public void Should_NotBeAbleToMakePaymentWith_InsufficentFunds()
        {
            var card = new PaymentCard();

            card.TopUp(10);
            
            Assert.Throws<Exception>(() => card.MakePayment(20));
        }

        [Test]
        public void Should_OnlyAcceptMinimumPayment_OfTenPoundsOnTopUp()
        {
            var card = new PaymentCard();

            Assert.Throws<Exception>(() => card.TopUp(5));
        }
    }
}