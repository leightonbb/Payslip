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
        public void Print(Employee employee)
        {
            Console.WriteLine(Format(employee));
        }
        private string Format(Employee employee)
        {
            //David Rudd,01 March – 31 March,5004,922,4082,450
            var lineBuilder = new StringBuilder();
            lineBuilder.Append(Format(employee.Name));
            lineBuilder.Append(",");
            lineBuilder.Append("XXXX Unfinished");
            lineBuilder.Append(",");

            return lineBuilder.ToString();
        }
        private string Format(EmployeeName employeeName)
        {
            return String.Format("{0} {1}", employeeName.First, employeeName.Last);
        }
    }
}
