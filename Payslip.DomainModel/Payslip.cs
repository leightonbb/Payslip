using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public class Payslip
    {
        public Payslip(PayPeriod payPeriod, AnnualSalary annualSalary, TaxTable taxTable)
        {
            PayPeriod = payPeriod;
            GrossIncome = annualSalary.CalcMonthlyGrossAmount();
            IncomeTax = taxTable.CalculateIncomeTax(annualSalary) / 12;
            IncomeTax = IncomeTax.RoundToNearestDollar();
            //IncomeTax = (new Money(922));
            NetIncome = GrossIncome - IncomeTax;
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
    }
}
