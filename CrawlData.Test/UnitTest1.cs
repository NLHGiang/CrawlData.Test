using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrawlData.Test
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ShouldReturnSum_WhenTwoNumbersAreProvided()
        {
            var num1 = 5;
            var num2 = 10;
            var result = _calculator.Add(num1, num2);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnDifference_WhenTwoNumbersAreProvided()
        {
            var num1 = 10;
            var num2 = 5;
            var result = _calculator.Subtract(num1, num2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnProduct_WhenTwoNumbersAreProvided()
        {
            var num1 = 4;
            var num2 = 5;
            var result = _calculator.Multiply(num1, num2);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Divide_ShouldReturnQuotient_WhenDividedByNonZeroNumber()
        {
            var num1 = 10;
            var num2 = 2;
            var result = _calculator.Divide(num1, num2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividedByZero()
        {
            var num1 = 10;
            var num2 = 0;
            var result = _calculator.Divide(num1, num2);
        }

        [TestMethod]
        public void Add_ShouldReturnSum_WhenTwoPositiveNumbersAreProvided()
        {
            Assert.AreEqual(15, _calculator.Add(5, 10));
        }

        [TestMethod]
        public void Add_ShouldReturnSum_WhenNegativeAndPositiveNumberAreProvided()
        {
            Assert.AreEqual(0, _calculator.Add(-5, 5));
        }

        [TestMethod]
        public void Add_ShouldReturnSum_WhenTwoNegativeNumbersAreProvided()
        {
            Assert.AreEqual(-15, _calculator.Add(-5, -10));
        }

        [TestMethod]
        public void Subtract_ShouldReturnDifference_WhenTwoPositiveNumbersAreProvided()
        {
            Assert.AreEqual(5, _calculator.Subtract(10, 5));
        }

        [TestMethod]
        public void Subtract_ShouldReturnNegative_WhenLesserNumberIsSubtractedFromGreater()
        {
            Assert.AreEqual(-5, _calculator.Subtract(5, 10));
        }

        [TestMethod]
        public void Subtract_ShouldReturnZero_WhenSameNumbersAreSubtracted()
        {
            Assert.AreEqual(0, _calculator.Subtract(5, 5));
        }

        [TestMethod]
        public void Multiply_ShouldReturnProduct_WhenTwoPositiveNumbersAreProvided()
        {
            Assert.AreEqual(20, _calculator.Multiply(4, 5));
        }

        [TestMethod]
        public void Multiply_ShouldReturnZero_WhenOneNumberIsZero()
        {
            Assert.AreEqual(0, _calculator.Multiply(0, 5));
        }

        [TestMethod]
        public void Multiply_ShouldReturnNegative_WhenOneNegativeAndOnePositiveNumberAreProvided()
        {
            Assert.AreEqual(-20, _calculator.Multiply(-4, 5));
        }

        [TestMethod]
        public void Divide_ShouldReturnNegative_WhenDividingNegativeByPositive()
        {
            Assert.AreEqual(-5, _calculator.Divide(-10, 2));
        }

        [TestMethod]
        public void Divide_ShouldReturnNegative_WhenDividingPositiveByNegative()
        {
            Assert.AreEqual(-5, _calculator.Divide(10, -2));
        }

        [TestMethod]
        public void Divide_ShouldReturnPositive_WhenDividingTwoNegativeNumbers()
        {
            Assert.AreEqual(5, _calculator.Divide(-10, -2));
        }

        [TestMethod]
        public void Add_ShouldReturnSum_WhenAddingLargeNumbers()
        {
            Assert.AreEqual(2000000, _calculator.Add(1000000, 1000000));
        }

        [TestMethod]
        public void Subtract_ShouldReturnNegative_WhenSubtractingLargeNumbers()
        {
            Assert.AreEqual(-1000000, _calculator.Subtract(1000000, 2000000));
        }

        [TestMethod]
        public void Multiply_ShouldReturnZero_WhenMultiplyingLargeNumberByZero()
        {
            Assert.AreEqual(0, _calculator.Multiply(1000000, 0));
        }

        [TestMethod]
        public void Divide_ShouldReturnQuotient_WhenDividingLargeNumbers()
        {
            Assert.AreEqual(2, _calculator.Divide(1000000, 500000));
        }

        [TestMethod]
        public void Add_ShouldHandleDecimalNumbers()
        {
            Assert.AreEqual(5.5, _calculator.Add(2.5, 3.0), 0.001);
        }

        [TestMethod]
        public void Subtract_ShouldHandleDecimalNumbers()
        {
            Assert.AreEqual(1.5, _calculator.Subtract(5.5, 4.0), 0.001);
        }

        [TestMethod]
        public void Multiply_ShouldHandleDecimalNumbers()
        {
            Assert.AreEqual(7.5, _calculator.Multiply(2.5, 3.0), 0.001);
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}