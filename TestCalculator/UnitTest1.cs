using NUnit.Framework;
using Lab_1.Implementations;

namespace Lab_1.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_AddsTwoNumbers_ReturnsCorrectResult()
        {
            double result = _calculator.Add(3, 5);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_SubtractsTwoNumbers_ReturnsCorrectResult()
        {
            double result = _calculator.Subtract(10, 3);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Multiply_MultipliesTwoNumbers_ReturnsCorrectResult()
        {
            double result = _calculator.Multiply(4, 5);
            Assert.AreEqual(20, result);
        }

        [Test]
        public void Divide_DividesTwoNumbers_ReturnsCorrectResult()
        {
            double result = _calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_DivisionByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}
