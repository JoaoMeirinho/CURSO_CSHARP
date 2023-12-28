using ExInterface.Entities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterface.Services
{
    class ContractService
    {
        private IPayment _payment;

        public ContractService(IPayment payment)
        {
            _payment = payment;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _payment.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _payment.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
