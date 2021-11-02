using System;
using NUnit.Framework;
using Calculator;

namespace UnitTesting
{
    [TestFixture]
    public class CalculatorCommandsTest
    {
        private static object[] MultiplyCases ={
            new object[] { 3, 4, 12 },
            new object[] { -1, -2, 2 },
            new object[] { -100, 4, -400 },
            new object[] { 0, 1000, 0 }
        };

        [TestCase(5, 7, 12)]
        [TestCase(1, 2.5, 3.5)]
        [TestCase(-3, -1, -4)]
        [TestCase(10, -100, -90)]
        public void SumNumbersTest(double a, double b, double expected)
        {
            Assert.AreEqual(expected, CalculatorCommands.Sum(a,b) );
        }

        [TestCase(7, 5, 2)]
        [TestCase(0, 10, -10)]
        [TestCase(-3, -1, -2)]
        [TestCase(10, 0, 10)]
        public void SubstractNumbersTest(double a, double b, double expected)
        {
            Assert.AreEqual(expected, CalculatorCommands.Substract(a, b));
        }

        [TestCaseSource(nameof(MultiplyCases))]
        public void MultiplyNumbersTest(double a, double b, double expected)
        {
            Assert.AreEqual(expected, CalculatorCommands.Multiply(a, b));
        }

        [Test]
        public void DivideNumbersReturnsNumberAboveZeroCaseTest()
        {
            Assert.AreEqual(2, CalculatorCommands.Divide(10, 5));
        }

        [Test]
        public void DivideNumbersReturnsNumberBelowZeroCaseTest()
        {
            Assert.AreEqual(-2, CalculatorCommands.Divide(10, -5));
        }

        [Test]
        public void DivideNumbersReturnsNumberEqualZeroCaseTest()
        {
            Assert.AreEqual(0, CalculatorCommands.Divide(0, 10));
        }

        [Test]
        public void DivideNumbersReturnsDivideByZeroExceprionCaseTest()
        {
            Assert.Throws<DivideByZeroException>(() => CalculatorCommands.Divide(10, 0));
        }

    }
}