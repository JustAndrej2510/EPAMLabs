using System;
using NUnit.Framework;
using Calculator;

namespace UnitTesting
{
    [TestFixture]
    public class CalculatorCommandsTest
    {
        private static object[] _multiplyCases ={
            new object[] { 3, 4, 12 },
            new object[] { -1, -2, 2 },
            new object[] { -100, 4, -400 },
            new object[] { 0, 1000, 0 }
        };

        [TestCase(5, 7, 12)]
        [TestCase(1, 2.5, 3.5)]
        [TestCase(-3, -1, -4)]
        [TestCase(10, -100, -90)]
        public void Sum_ValidInputValues_ReturnsExpected(double a, double b, double expected)
        {
            var actual = CalculatorCommands.Sum(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 5, 2)]
        [TestCase(0, 10, -10)]
        [TestCase(-3, -1, -2)]
        [TestCase(10, 0, 10)]
        public void Substract_ValidInputValues_ReturnsExpected(double a, double b, double expected)
        {
            var actual = CalculatorCommands.Substract(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(_multiplyCases))]
        public void Multiply_ValidInputValues_ReturnsExpected(double a, double b, double expected)
        {
            var actual = CalculatorCommands.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5, 2)]
        [TestCase(0, 10, 0)]
        [TestCase(-3, 100, -0.03)]
        public void Divide_ValidInputValues_ReturnsNumberAboveZero(double a, double b, double expected)
        {
            var actual = CalculatorCommands.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_InvalidDividerEqualToZero_ThrowsDivideByZeroException()
        {
            var dividend = 10;
            var divider = 0;

            Assert.Throws<DivideByZeroException>(() => CalculatorCommands.Divide(dividend, divider));
        }

    }
}