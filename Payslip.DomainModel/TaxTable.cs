using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public class TaxTable
    {
        public Money CalculateIncomeTax(AnnualSalary taxableIncome)
        {
            decimal taxAmount = 0;

            taxAmount += taxableIncome.AmountInTaxBand(0, 18200) * 0;
            taxAmount += taxableIncome.AmountInTaxBand(18200, 37000) * 0.19m;
            taxAmount += taxableIncome.AmountInTaxBand(37000, 80000) * 0.325m;
            taxAmount += taxableIncome.AmountInTaxBand(80000, 180000) * 0.37m;
            taxAmount += taxableIncome.AmountOverTaxBand(180000) * 0.45m;

            return new Money(taxAmount);
        }
    }
}
