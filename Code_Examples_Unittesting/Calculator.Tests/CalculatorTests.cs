using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    internal class CalculatorTests
    {

        [TestCase(10, 20, ExpectedResult = 30)]
        [TestCase(-10, 20, ExpectedResult = 10)]
        [TestCase(10, -20, ExpectedResult = -10)]
        [TestCase(100, 20, ExpectedResult = 120)]
        [TestCase(20, 20, ExpectedResult = 40)]
        public int Sum_With2PositiveIntegerNumbers_ReturnsCorrectSum(int firstNumber, int secondNumber)
        {
            // Arrange
            Calculator sut = new Calculator();

            // Act

            int result = sut.Sum(firstNumber, secondNumber);

            // Assert
            return result;
        }
    }
}
