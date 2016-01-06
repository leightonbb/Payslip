using Payslip.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipCodingExcercise
{
    class EmployeePayslipPrinter
    {
        public void Print(Employee employee, Payslip.DomainModel.Payslip paySlip)
        {
            Console.WriteLine(Format(employee, paySlip));
        }
        private string Format(Employee employee, Payslip.DomainModel.Payslip paySlip)
        {
            //Output (name, pay period, gross income, income tax, net income, super):
            //David Rudd,01 March – 31 March,5004,922,4082,450
            var lineBuilder = new StringBuilder();
            lineBuilder.Append(Format(employee.Name));
            lineBuilder.Append(",");
            lineBuilder.Append(Format(paySlip.PayPeriod));
            lineBuilder.Append(",");
            lineBuilder.Append(paySlip.GrossIncome);
            lineBuilder.Append(",");
            lineBuilder.Append(paySlip.IncomeTax);
            lineBuilder.Append(",");

            return lineBuilder.ToString();
        }

        private string Format(PayPeriod payPeriod)
        {
            return payPeriod.StartDate.ToString("dd MMMM") + " - " + payPeriod.EndDate.ToString("dd MMMM");
            //return payPeriod.ToString();
        }

        private string Format(EmployeeName employeeName)
        {
            return String.Format("{0} {1}", employeeName.First, employeeName.Last);
        }
    }
}
