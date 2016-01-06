using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipCodingExcercise.DataAccess
{
    sealed class CsvRowMap : CsvClassMap<CsvRow>
    {
        public CsvRowMap()
        {
            Map(m => m.FirstName);
            Map(m => m.LastName);
            Map(m => m.AnnualSalary);
            Map(m => m.SuperRate).Index(3).TypeConverterOption("P");
            Map(m => m.PaymentStartDate).TypeConverter<PayPeriodConverter>();
        }
    }
}
