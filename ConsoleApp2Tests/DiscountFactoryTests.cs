using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class DiscountFactoryTests
    {
        [TestMethod()]
        [DataRow(12, 1, 7)]
        public void DiscountCalculatorTest(double price, int clientType, int years)
        {
            var df = DiscountFactory.DiscountCalculator((decimal)price, clientType, years);

            Assert.AreEqual((decimal)price, df);
        }

        [TestMethod()]
        [DataRow(13, 2, 8)]
        public void DiscountCalculatorTest1(double price, int clientType, int years)
        {
            var df = DiscountFactory.DiscountCalculator((decimal)price, clientType, years);

            Assert.AreEqual(10.881m, df);
        }
    }
}