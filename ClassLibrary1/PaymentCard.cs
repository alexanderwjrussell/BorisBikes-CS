using System.Security.Permissions;

namespace BorisBikes
{
    public class PaymentCard
    {
        public int Balance { get; private set; }
        public PaymentCard()
        {
            int Balance = 0;
        }

        public void TopUp(int amount)
        {
            Balance += amount;
        }

        public void Payment(int amount)
        {
            Balance -= amount;
        }
    }
}
