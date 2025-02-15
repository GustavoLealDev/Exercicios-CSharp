using System.Text;

namespace Course.Entities
{
     class Installment
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public override string ToString()
        {
           return Date.ToString("dd/MM/yyyy") + ", $" + Amount;
        }
    }
}
