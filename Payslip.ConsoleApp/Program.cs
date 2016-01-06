using CsvHelper;
using Payslip.DomainModel;
using PayslipCodingExcercise.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipCodingExcercise
{
    // Create created this program primarily to help me focus on some tangible requirements when creating my test...

    class Program
    {
        static void Main(string[] args)
        {

            var repo = new EmployeeRepository();
            var printer = new EmployeePayslipPrinter();

            var payPeriod = new PayPeriod(3);
            var taxTable = new TaxTable();

            var employees = repo.GetAll();
            foreach (var employee in employees)
            {
                var paySlip = employee.CreatePayslip(payPeriod, taxTable);

                printer.Print(employee, paySlip);
            }

            Console.ReadKey();
        }
    }
}
