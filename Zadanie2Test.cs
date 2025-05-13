using bezględność;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    [TestClass]

    public class CalculatorTest

    {

        [TestMethod]

        public void AbsoluteValue_NegativeNumber_ReturnsPositive()
        {

            var zadanie = new Zadanie2();

            double result = zadanie.AbsoluteValue(-10);

            Assert.AreEqual(10, result);

        }

        [TestMethod]
        public void AbsoluteValue_PositiveNumber_ReturnsSame()
        {

            var zadanie1 = new Zadanie2();

            double result1 = zadanie1.AbsoluteValue(7);

            Assert.AreEqual(7, result1);

        }

        [TestMethod]

        public void AbsoluteValue_Zero_ReturnsZero()
        {
            var zadanie2 = new Zadanie2();

            double result2 = zadanie2.AbsoluteValue(0);

            Assert.AreEqual(0, result2);

        }
    }
}

