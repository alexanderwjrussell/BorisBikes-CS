using System;
using System.Security.Permissions;

namespace BorisBikes
{
    public class PaymentCard
    {
        public const int MinimumnBalance = 10;
        public int Balance { get; private set; }
        public PaymentCard()
        {
            int Balance = 0;
        }

        public void TopUp(int amount)
        {
            if (amount + Balance < MinimumnBalance)
                throw new Exception("Less than the minimum required balance");
            Balance += amount;
        }

        public void MakePayment(int amount)
        {
            if (Balance < amount)
                throw new Exception("Insufficinet Funds!");

            Balance -= amount;
        }
    }
}
