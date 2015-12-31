using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public struct Money
    {
        public Money(decimal amount)
        {
            _amount = amount;
        }
        decimal _amount;

        public override bool Equals(object obj)
        {
            Money other = (Money)obj;
            return other._amount == _amount;
        }

        public Money RoundToNearestCent()
        {
            var roundedAmount = Math.Round(_amount, 2);

            return new Money(roundedAmount);
        }
        public Money RoundToNearestDollar()
        {
            var roundedAmount = Math.Round(_amount, 0);

            return new Money(roundedAmount);
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }

        public override string ToString()
        {
            return _amount.ToString();
        }
    }
}
