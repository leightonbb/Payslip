using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public class PercentageRate
    {
        public PercentageRate(int percent)
        {

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
    }
}
