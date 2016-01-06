using Payslip.DomainModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public class Employee :
        AggregateRoot
    {
        public Employee()
        {
            Name = new EmployeeName("", "");
            AnnualSalary = new AnnualSalary(0);
            SuperRate = new PercentageRate(0);
        }

        public EmployeeName Name { get; set; }
        public AnnualSalary AnnualSalary { get; set; }
        public PercentageRate SuperRate { get; set; }

        public Payslip CreatePayslip(PayPeriod payPeriod, TaxTable taxTable)
        {
            var grossIncome = AnnualSalary.CalcMonthlyGrossAmount();
            var incomeTax = taxTable.CalculateIncomeTax(AnnualSalary) / 12;
            incomeTax = incomeTax.RoundToNearestDollar();
            var super = (grossIncome * SuperRate).RoundToNearestDollar();

            return new Payslip(
                payPeriod,
                grossIncome,
                incomeTax,
                super);
        }
    }
}
