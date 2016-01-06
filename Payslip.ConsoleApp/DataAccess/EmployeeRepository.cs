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
    /// <summary>
    /// Originally though that this would be the main repository, but discovered that the csv contained 
    /// "PayslipRequests" rather than employees, so moved most of the contents out of this class.
    /// </summary>
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
