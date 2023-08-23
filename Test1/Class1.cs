

using NUnit.Framework;
using Practices;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Additional_ShouldReturnCorrectResult()
        {
            int result = calculator.Additional(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtraction_ShouldReturnCorrectResult()
        {
            int result = calculator.Subtraction(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Miltiplication_ShouldReturnCorrectResult()
        {
            int result = calculator.Miltiplication(5, 3);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Division_ShouldReturnCorrectResult()
        {
            int result = calculator.Division(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Division_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}



