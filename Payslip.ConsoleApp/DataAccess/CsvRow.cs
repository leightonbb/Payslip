using Payslip.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipCodingExcercise.DataAccess
{
    /// <summary>
    /// Contains all the fields for mapping directly to the csv file.
    /// </summary>
    class CsvRow
    {
        public string FirstName {get; set; }
        public string LastName { get; set; }
        public int AnnualSalary { get; set; }
        
        /// <summary>
        /// The conversion could happen in the mapping, if i had a little more time.
        /// </summary>
        //public PercentRate SuperRate { get; set; }
        public string SuperRate { get; set; }

        public PayPeriod PaymentStartDate { get; set; }
    }
}
