namespace Course.Entities
{
    class IndividualTax : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualTax(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            if (AnualIncome < 20000)
            {
                return AnualIncome * 0.15;
            }
            else if (AnualIncome > 20000 && HealthExpenditures > 0)
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
            else 
            {
               return AnualIncome * 0.25;
            }
        }
    }
}
