using System.Diagnostics.CodeAnalysis;
using Course.Entities;

namespace Course.Services
{
    class ContractService
    {
        private ITaxService _taxService;
        public ContractService(ITaxService taxService)
        {
            _taxService = taxService;
        }

        public void ProcessContract(Contract contract, int mounths)
        {
            double sum = contract.ContractValue / mounths;
            for (int i = 1; i <= mounths; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatSum = sum + _taxService.Interest(sum, i);
                double fullSum = updatSum + _taxService.PaymentFee(updatSum);
                contract.AddInstallments(new Installment(date, fullSum));
            }
        }

    }
}
