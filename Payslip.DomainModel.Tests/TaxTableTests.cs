using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel.Tests
{
    [TestClass]
    public class TaxTableTests
    {
        [TestMethod]
        public void Call_CalculateIncomeTax_WhenThirdTaxBracket60050_Returns921o9375()
        {
            var target = new TaxTable();
            var result = target.CalculateIncomeTax(new AnnualSalary(60050));

            Assert.AreEqual(new Money(11063.250m), result);
        }
        [TestMethod]
        public void Call_CalculateIncomeTax_WhenForthTaxBracket120000_Returns2696()
        {
            var target = new TaxTable();
            var result = target.CalculateIncomeTax(new AnnualSalary(120000));

            Assert.AreEqual(new Money(32347.000m), result);
        }
        
    }
}
