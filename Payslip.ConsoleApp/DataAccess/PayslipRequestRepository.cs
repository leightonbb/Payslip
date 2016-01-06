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
    class PayslipRequestRepository
    {
        public IEnumerable<PayslipRequest> GetAll()
        {
            IEnumerable<CsvRow> records = ReadAllCsvRows();

            // I could have used link here to do the conversion, but i think spelling it out in this case makes it clearer...
            var result = new List<PayslipRequest>();
            foreach (var record in records)
            {
                var employee = EmployeeRepository.CreateEmployee(record);

                var newRequest = new PayslipRequest(employee, record.PaymentStartDate);

                result.Add(newRequest);
            }
            return result;
        }

        private static IEnumerable<CsvRow> ReadAllCsvRows()
        {
            var textReader = new StreamReader("DataToImport.csv");
            var csv = new CsvReader(textReader);
            csv.Configuration.HasHeaderRecord = false;
            csv.Configuration.RegisterClassMap<CsvRowMap>();

            var records = csv.GetRecords<CsvRow>();
            return records.ToList();
        }

    }
}
