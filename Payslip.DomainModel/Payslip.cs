using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public class Payslip
    {
        public Payslip(PayPeriod payPeriod, Money grossIncome)
        {
            PayPeriod = payPeriod;
            GrossIncome = grossIncome;
        }

        public PayPeriod PayPeriod { get; private set;}

        public Money GrossIncome
        {
            get;
            private set;
        }
    }
}
