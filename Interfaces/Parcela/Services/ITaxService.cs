namespace Course.Services
{
    interface ITaxService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int mounths);
    }
}
