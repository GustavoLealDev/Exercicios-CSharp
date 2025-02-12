namespace Course.Entities
{
    class CompanyTax : TaxPayer
    {
        public int Employees { get; set; }

        public CompanyTax(int employees, string name, double anualIncome) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if (Employees < 10)
            {
                return AnualIncome * 0.16;
            } 
            else 
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
