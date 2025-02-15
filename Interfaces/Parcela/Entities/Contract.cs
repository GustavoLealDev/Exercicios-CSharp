namespace Course.Entities
{
    class Contract
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int id, DateTime date, double contractValue)
        {
            Id = id;
            Date = date;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }
        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
