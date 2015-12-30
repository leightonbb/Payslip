using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.DomainModel.Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void Call_RoundToNearestCent_WhenDecimal6897_ReturnsDecimal69()
        {
            var target = new Money(45.6897m);
            var result = target.RoundToNearestCent();
            Assert.AreEqual(new Money(45.69m), result);
        }
        [TestMethod]
        public void Call_RoundToNearestCent_WhenDecimal0_ReturnsDecimal0()
        {
            var target = new Money(66.00m);
            var result = target.RoundToNearestCent();
            Assert.AreEqual(new Money(66.00m), result);
        }
        [TestMethod]
        public void Call_RoundToNearestCent_WhenDecimal623_ReturnsDecimal62()
        {
            var target = new Money(88.623m);
            var result = target.RoundToNearestCent();
            Assert.AreEqual(new Money(88.62m), result);
        }
        [TestMethod]
        public void Call_RoundToNearestCent_WhenDecimal675_ReturnsDecimal68()
        {
            var target = new Money(45.675m);
            var result = target.RoundToNearestCent();
            Assert.AreEqual(new Money(45.68m), result);
        }
        [TestMethod]
        public void Call_RoundToNearestDollar_When45o6897_ReturnsDecimal46()
        {
            var target = new Money(45.6897m);
            var result = target.RoundToNearestDollar();
            Assert.AreEqual(new Money(46m), result);
        }
        [TestMethod]
        public void Call_RoundToNearestDollar_When66o0_Returns66o0()
        {
            var target = new Money(66.00m);
            var result = target.RoundToNearestDollar();
            Assert.AreEqual(new Money(66.00m), result);
        }
        [TestMethod]
        public void Call_RoundToNearestDollar_When88o23_Returns88()
        {
            var target = new Money(88.23m);
            var result = target.RoundToNearestDollar();
            Assert.AreEqual(new Money(88.0m), result);
        }
    }
}
