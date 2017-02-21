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
            card.Payment(10);

            Assert.That(card.Balance, Is.EqualTo(0));
        }
    }
}