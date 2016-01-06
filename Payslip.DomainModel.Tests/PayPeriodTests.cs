using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payslip.DomainModel.Tests
{
    [TestClass]
    public class PayPeriodTests
    {
        [TestMethod]
        public void Call_ToString_When3_ReturnsCorrectMarchText()
        {
            var target = new PayPeriod(3);
            Assert.AreEqual("01 March to 31 March", target.ToString());
        }
        [TestMethod]
        public void Call_ToString_When4_ReturnsCorrectAprilText()
        {
            var target = new PayPeriod(4);
            Assert.AreEqual("01 April to 30 April", target.ToString());
        }
        [TestMethod]
        public void Call_ToString_When2_ReturnsCorrectFebruaryText()
        {
            var target = new PayPeriod(2);
            Assert.AreEqual("01 February to 28 February", target.ToString());
        }
    }
}
