using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public struct PercentageRate
    {
        public PercentageRate(int percent)
        {
            _percent = percent;
        }
        private int Percent
        {
            get
            {
                return _percent;
            }
            set
            {
                //if (value > 100)
                //    throw new Arg
                _percent = value;
            }
        }
        int _percent;

        internal decimal AsDecimal()
        {
            return Percent / 100.0m;
        }
    }
}
