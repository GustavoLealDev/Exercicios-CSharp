using System.IO.Pipes;

namespace Course.Services
{
    class PaypalService : ITaxService
    {
        public double FeePeercentage = 0.02;
        public double FeeInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * FeePeercentage;
        }

        public double Interest(double amount, int mounths)
        {
            return amount * FeeInterest * mounths;
        }
    }
}
