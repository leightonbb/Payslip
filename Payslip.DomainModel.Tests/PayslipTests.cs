using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payslip.DomainModel.Tests
{
    [TestClass]
    public class PayslipTests
    {
        [TestMethod]
        public void Get_NetIncome_WithSalary120000_Returns7304()
        {
            var target = new Payslip(
                new PayPeriod(1),
                new Money(8304),
                new Money(1000),
                new Money(0));

            Assert.AreEqual(new Money(7304), target.NetIncome);
        }
    }
}
