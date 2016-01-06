using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public struct PayslipRequest
    {
        public PayslipRequest(Employee employee, PayPeriod payPeriod)
        {
            Employee = employee;
            PayPeriod = payPeriod;
        }
        public Employee Employee
        {
            get;
            private set;
        }
        public PayPeriod PayPeriod
        {
            get;
            private set;
        }

        public Payslip CreatePayslip(TaxTable taxTable)
        {
            return Employee.CreatePayslip(PayPeriod, taxTable);
        }
    }
}
