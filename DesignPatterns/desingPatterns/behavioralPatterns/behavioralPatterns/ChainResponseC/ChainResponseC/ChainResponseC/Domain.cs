using ChainResponseC.ChainResponseC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseC
{
    public class Domain
    {
        private Employee employee { get; set; }
        public string CustomerId { get; }
        public decimal Amount { get; }
        public string CurrencyType { get; }
        public string SoruceAccountId { get; }

        public Domain(string customerId, decimal amount, string currencyType, string soruceAccountId)
        {
            CustomerId = customerId;
            Amount = amount;
            CurrencyType = currencyType;
            SoruceAccountId = soruceAccountId;
        }

        public void Process(Employee employee)
        {
            this.employee = employee;
            employee.ProcessRequest(this);
        }
    }
}
