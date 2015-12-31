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
        public EmployeeRepository()
        {

        }

        public IEnumerable<Employee> GetAll()
        {
            var textReader = new StreamReader("DataToImport.csv");
            var csv = new CsvReader(textReader);
            csv.Configuration.HasHeaderRecord = false;

            var records = csv.GetRecords<CsvRow>();

            // I could have used link here to do the conversion, but i think spelling it out in this case makes it clearer...
            var result = new List<Employee>();
            foreach (var record in records)
            {
                var employee = new Employee()
                {
                    Name = new EmployeeName(record.FirstName, record.LastName),
                    AnnualSalary = new AnnualSalary(record.AnnualSalary),
                    //SuperRate = new PercentageRate(record.SuperRate),
                };
                result.Add(employee);
            }
            return result;
        }
    }
}
