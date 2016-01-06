using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    /// <summary>
    /// Helps to identify that a value is refering to money.
    /// Provides convienient way of rounding money values.
    /// Limits operations to ensure only money gets add / subtracted from other money.
    /// </summary>
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

        public static Money operator + (Money left, Money right)
        {
            return new Money(left._amount + right._amount);
        }
        public static Money operator -(Money left, Money right)
        {
            return new Money(left._amount - right._amount);
        }
        public static Money operator /(Money left, decimal right)
        {
            return new Money(left._amount / right);
        }
    }
}
