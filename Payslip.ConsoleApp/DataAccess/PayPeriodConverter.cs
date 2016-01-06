using CsvHelper.TypeConversion;
using Payslip.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipCodingExcercise.DataAccess
{
    class PayPeriodConverter :
        ITypeConverter
    {
        public bool CanConvertFrom(Type type)
        {
            if (type == typeof(string))
            {
                return true;
            }
            return false;
        }

        public bool CanConvertTo(Type type)
        {
            if (type == typeof(PayPeriod))
            {
                return true;
            }
            return false;
        }

        public object ConvertFromString(TypeConverterOptions options, string text)
        {
            string[] parts = text.Split(new char[] { '-', '\u2013'});
            string textBeforeHyphen = parts[0];
            var startDate = DateTime.Parse(textBeforeHyphen);
            var month = startDate.Month;
            return new PayPeriod(month);
        }

        public string ConvertToString(TypeConverterOptions options, object value)
        {
            throw new NotImplementedException();
        }
    }
}
