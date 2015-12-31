using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel
{
    public struct EmployeeName
    {
        public EmployeeName(string first, string last)
        {
            First = first;
            Last = last;
        }
        public string First { get; private set; }
        public string Last { get; private set; }
    }
}
