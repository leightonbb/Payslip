using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public struct AnnualSalary
    {
        public AnnualSalary(decimal annualAmountBeforeTax)
        {
            _annualAmountBeforeTax = annualAmountBeforeTax;
        }
        decimal _annualAmountBeforeTax;

        internal decimal AmountInTaxBand(int topOfPreviousBand, int topOfBand)
        {
            if (_annualAmountBeforeTax <= topOfPreviousBand)
                return 0;

            var trimmedAnnualAmount = Math.Min(_annualAmountBeforeTax, topOfBand);
            return trimmedAnnualAmount - topOfPreviousBand;
        }

        internal Money CalcMonthlyGrossAmount()
        {
            var nonRoundedAmount = new Money(_annualAmountBeforeTax / 12);
            //return nonRoundedAmount;
            return nonRoundedAmount.RoundToNearestDollar();
        }

        internal decimal AmountOverTaxBand(int topOfBand)
        {
            if (_annualAmountBeforeTax <= topOfBand)
                return 0;

            return _annualAmountBeforeTax - topOfBand;
        }
    }
}
