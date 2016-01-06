using CsvHelper;
using Payslip.DomainModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipCodingExcercise.DataAccess
{
    class EmployeeRepository
    {
        internal static Employee CreateEmployee(CsvRow record)
        {
            var superRateText = record.SuperRate.Trim('%');
            var superRateAsDecimal = Int32.Parse(superRateText);

            var employee = new Employee()
            {
                Name = new EmployeeName(record.FirstName, record.LastName),
                AnnualSalary = new AnnualSalary(record.AnnualSalary),
                SuperRate = new PercentageRate(superRateAsDecimal),
            };
            return employee;
        }
    }
}
