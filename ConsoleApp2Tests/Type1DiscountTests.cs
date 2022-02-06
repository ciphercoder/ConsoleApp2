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
    public class Type1DiscountTests
    {
        [TestMethod()]
        [DataRow(12, 1, 7)]
        [DataRow(13, 1, 7)]
        public void CalculateDiscountTest(double price, int clientType, int years)
        {
            var df = DiscountFactory.DiscountCalculator((decimal)price, 1, years);

            Assert.AreEqual((decimal)price, df);

        }
    }
}