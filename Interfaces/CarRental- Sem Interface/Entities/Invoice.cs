using System.Text;

namespace Course.Entities
{
     class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INVOICE:");
            sb.AppendLine("Basic payment: " + BasicPayment.ToString("F2"));
            sb.AppendLine("Tax: " + Tax.ToString("F2"));
            sb.AppendLine("Total payment: " + TotalPayment.ToString("F2"));
            return sb.ToString();
        }

    }
}
