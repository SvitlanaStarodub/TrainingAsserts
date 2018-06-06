namespace CalculatorTests
{
    using Calculator;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Start test");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Finish test");
        }

        #region Addition Method


        [Test]
        [Category("Addition")]
        [TestCase(22, 16, 38)]
        [TestCase(20, 16, 36)]
        [TestCase(-1, 16, 15)]
        public void Addition_ValidData_ReturnsSum(int x, int y, int expected)
        {
            // act 
            int actual = Calculator.Addition(x, y);

            // assert
            Assert.AreEqual(expected, actual, "Result of Addition operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Addition")]
        public void Addition_ValidData_ReturnsSum()
        {
            // arrange 
            int x = 22;
            int y = 16;
            int expected = 38;

            // act 
            int actual = Calculator.Addition(x, y);

            // assert
            Assert.AreEqual(expected, actual, "Result of Addition operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Addition")]
        public void Addition_validDataConstraintBased_ReturnsSum()
        {
            // arrange 
            int x = 22;
            int y = 16;
            int expected = 40;

            // act 
            int actual = Calculator.Addition(x, y);

            // assert
            Assert.That(actual, Is.EqualTo(expected), "Result of Addition operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Addition")]
        public void Addition_MaxValues_ReturnsSum()
        {
            // arrange 
            int x = Calculator.MaxValue;
            int y = Calculator.MaxValue;
            int expected = 200000000;

            // act 
            int actual = Calculator.Addition(x, y);

            // assert
            Assert.AreEqual(expected, actual, "Result of Addition operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Addition")]
        public void Addition_MinValues_ReturnsSum()
        {
            // arrange 
            int x = Calculator.MinValue;
            int y = Calculator.MinValue;
            int expected = -200000000;

            // act 
            int actual = Calculator.Addition(x, y);

            // assert
            Assert.AreEqual(expected, actual, "Result of Addition operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Addition")]
        public void Addition_XLessThenMinValue_ThrowsArgumentException()
        {
            // arrange 
            int x = Calculator.MinValue - 1;
            int y = 0;
            string ExpectedExceptionMessage = String.Format("Operand X is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act/assert 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Addition(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        [Test]
        [Category("Addition")]
        public void Addition_YLessThenMinValue_ThrowsArguentException()
        {
            // arrange 
            int x = 0;
            int y = Calculator.MinValue - 1;
            string ExpectedExceptionMessage = String.Format("Operand Y is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Addition(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }


        [Test]
        [Category("Addition")]
        public void Addition_XMoreThenMaxValue_ThrowsArgumentException()
        {
            // arrange 
            int x = Calculator.MaxValue + 1;
            int y = 0;
            string ExpectedExceptionMessage = String.Format("Operand X is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Addition(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        [Test]
        [Category("Addition")]
        public void Addition_YMoreThenMaxValue_ThrowsException()
        {
            // arrange 
            int x = 0;
            int y = Calculator.MaxValue + 1;
            string ExpectedExceptionMessage = String.Format("Operand Y is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Addition(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        #endregion

        #region Division Method

        [Test]
        [Category("Division")]
        public void Division_ZeroArgumentToDivide_DivideByZeroException()
        {
            // arrange
            int x = 10;
            int zero = 0;

            // act 

            // assert
            Assert.That(() => Calculator.Division(x, zero), Throws.Exception.TypeOf<DivideByZeroException>()
                    .With.Message.EqualTo("Attempted to divide by zero."));
        }
        [Test]
        [Category("Division")]
        public void Division_validDataConstraintBased_ReturnsSum()
        {
            // arrange 
            int x = -20;
            int y = 2;
            long expected = -10;

            // act 
            long actual = Calculator.Division(x, y);

            // assert
            Assert.That(actual, Is.EqualTo(expected), "Result of Multiplication operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Division")]
        public void Division_MaxValues_ReturnsSum()
        {
            // arrange 
            int x = Calculator.MaxValue;
            int y = Calculator.MaxValue;
            long expected = 1;

            // act 
            long actual = Calculator.Division(x, y);

            // assert
            Assert.AreEqual(expected, actual, "Result of Multiplication operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Division")]
        public void Division_MinValues_ReturnsSum()
        {
            // arrange 
            int x = Calculator.MinValue;
            int y = Calculator.MinValue;
            long expected = 1;

            // act 
            long actual = Calculator.Division(x, y);

            // assert
            Assert.AreEqual(expected, actual, "Result of Multiplication operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Division")]
        public void Division_XLessThenMinValue_ThrowsArgumentException()
        {
            // arrange 
            int x = Calculator.MinValue - 1;
            int y = 0;
            string ExpectedExceptionMessage = String.Format("Operand X is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Multiplication(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        [Test]
        [Category("Division")]
        public void Division_YLessThenMinValue_ThrowsArguentException()
        {
            // arrange 
            int x = 0;
            int y = Calculator.MinValue - 1;
            string ExpectedExceptionMessage = String.Format("Operand Y is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Multiplication(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        [Test]
        [Category("Division")]
        public void Division_XMoreThenMaxValue_ThrowsArgumentException()
        {
            // arrange 
            int x = Calculator.MaxValue + 1;
            int y = 0;
            string ExpectedExceptionMessage = String.Format("Operand X is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Multiplication(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        [Test]
        [Category("Division")]
        public void Division_YMoreThenMaxValue_ThrowsException()
        {
            // arrange 
            int x = 0;
            int y = Calculator.MaxValue + 1;
            string ExpectedExceptionMessage = String.Format("Operand Y is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Multiplication(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }


        #endregion

        #region Multiplication Method
        [Test]
        [Category("Multiplication")]
        public void Multiplication_validDataConstraintBased_ReturnsSum()
        {
            // arrange 
            int x = 5;
            int y = -10;
            long expected = -50;

            // act 
            long actual = Calculator.Multiplication(x, y);

            // assert
            Assert.That(actual, Is.EqualTo(expected), "Result of Multiplication operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Multiplication")]
        public void Multiplication_MaxValues_ReturnsSum()
        {
            // arrange 
            int x = Calculator.MaxValue;
            int y = Calculator.MaxValue;
            long expected = 10000000000000000;

            // act 
            long actual = Calculator.Multiplication(x, y);

            // assert
            Assert.AreEqual(expected, actual, "Result of Multiplication operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Multiplication")]
        public void Multiplication_MinValues_ReturnsSum()
        {
            // arrange 
            int x = Calculator.MinValue;
            int y = Calculator.MinValue;
            long expected = 10000000000000000;

            // act 
            long actual = Calculator.Multiplication(x, y);

            // assert
            Assert.AreEqual(expected, actual, "Result of Multiplication operation is invalid. Actual : {0}, Expected: {1} ",
                actual, expected);
        }

        [Test]
        [Category("Multiplication")]
        public void Multiplication_XLessThenMinValue_ThrowsArgumentException()
        {
            // arrange 
            int x = Calculator.MinValue - 1;
            int y = 0;
            string ExpectedExceptionMessage = String.Format("Operand X is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Multiplication(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        [Test]
        [Category("Multiplication")]
        public void Multiplication_YLessThenMinValue_ThrowsArguentException()
        {
            // arrange 
            int x = 0;
            int y = Calculator.MinValue - 1;
            string ExpectedExceptionMessage = String.Format("Operand Y is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Multiplication(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }


        [Test]
        [Category("Multiplication")]
        public void Multiplication_XMoreThenMaxValue_ThrowsArgumentException()
        {
            // arrange 
            int x = Calculator.MaxValue + 1;
            int y = 0;
            string ExpectedExceptionMessage = String.Format("Operand X is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Multiplication(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        [Test]
        [Category("Multiplication")]
        public void Multiplication_YMoreThenMaxValue_ThrowsException()
        {
            // arrange 
            int x = 0;
            int y = Calculator.MaxValue + 1;
            string ExpectedExceptionMessage = String.Format("Operand Y is invalid. Acceptable range from {0} to {1}",
                    Calculator.MinValue, Calculator.MaxValue); ;

            // act 
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                Calculator.Multiplication(x, y));

            // assert
            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
        }

        #endregion

    }
}