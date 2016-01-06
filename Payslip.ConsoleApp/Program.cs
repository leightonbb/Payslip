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

            var repo = new PayslipRequestRepository();
            var payslipRequests = repo.GetAll();

            var printer = new EmployeePayslipPrinter();
            var taxTable = new TaxTable();

            foreach (var request in payslipRequests)
            {
                var paySlip = request.CreatePayslip(taxTable);

                printer.Print(request.Employee, paySlip);
            }

            Console.ReadKey();
        }
    }
}
