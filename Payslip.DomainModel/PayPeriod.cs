using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public class PayPeriod
    {
        public PayPeriod(int monthNumber)
        {
            _monthNumber = monthNumber;
        }

        public override bool Equals(object obj)
        {
            var other = (PayPeriod)obj;
            return (other._monthNumber == _monthNumber);
        }

        int _monthNumber;

        public override int GetHashCode()
        {
            return _monthNumber.GetHashCode();
        }
    }
}
