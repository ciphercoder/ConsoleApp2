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
    public class Type4DiscountTests
    {
        [TestMethod()]
        [DataRow(17, 4, 8)]
        public void DiscountCalculatorTest1(double price, int clientType, int years)
        {
            var df = DiscountFactory.DiscountCalculator((decimal)price, clientType, years);

            Assert.AreEqual(6.324m, df);
        }
    }
}