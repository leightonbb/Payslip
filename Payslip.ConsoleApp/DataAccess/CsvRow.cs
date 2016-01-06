using Payslip.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipCodingExcercise.DataAccess
{
    class CsvRow
    {
        public string FirstName {get; set; }
        public string LastName { get; set; }
        public int AnnualSalary { get; set; }
        //public int SuperRate { get; set; }
        public string SuperRate { get; set; }
        public PayPeriod PaymentStartDate { get; set; }
    }
}
