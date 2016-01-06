using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public struct Payslip
    {
        public Payslip(PayPeriod payPeriod, Money grossIncome, Money incomeTax, Money super)
        {
            PayPeriod = payPeriod;
            GrossIncome = grossIncome;
            IncomeTax = incomeTax;

            NetIncome = GrossIncome - IncomeTax;
            Super = super;
        }

        public PayPeriod PayPeriod { get; private set;}

        public Money GrossIncome
        {
            get;
            private set;
        }
        public Money IncomeTax
        {
            get;
            private set;
        }
        public Money NetIncome
        {
            get;
            private set;
        }
        public Money Super
        {
            get;
            private set;
        }
    }
}
