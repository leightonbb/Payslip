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

        /// <summary>
        /// Formating for the UI should be the reposibility of another class (in the presentation layer rather than in the 
        /// domain model). This formatting is for convienance when working with and testing the domain model.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var startDate = new DateTime(2015, _monthNumber, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            return startDate.ToString("dd MMMM") + " to " + endDate.ToString("dd MMMM");
        }
    }
}
