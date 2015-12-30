using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payslip.DomainModel;

namespace Payslip.DomainModel.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Call_CreatePayslip_WithMarchPayPeriod_ReturnsPayslipWithMarchPayPeriod()
        {
            var target = new Employee();
            //target.Name = new EmployeeName("David", "Rudd");
            //target.AnnualSalary = new AnnualSalary(60050);
            //target.SuperRate = new PercentageRate(9);

            Payslip payslip = target.CreatePayslip(new PayPeriod(3));

            Assert.AreEqual(new PayPeriod(3), payslip.PayPeriod);
        }
        [TestMethod]
        public void Call_CreatePayslip_WithAnnualSalary60050_ReturnsPayslipWithGrossIncome5004()
        {
            var target = new Employee();
            target.AnnualSalary = new AnnualSalary(60050);

            Payslip payslip = target.CreatePayslip(new PayPeriod(3));

            Assert.AreEqual(new Money(5004), payslip.GrossIncome);
        }
    }
}
