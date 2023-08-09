using Xunit;

namespace Lectia23_1.Tests
{
    public class FactorialCalculatorTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(5, 120)]
        [InlineData(10, 3628800)]
        public void CalculateFactorial_ShouldReturnRightValue(int n, int expectedFactorial)
        {
            // Arrange
            FactorialCalculator calculator = new FactorialCalculator();

            // Act
            int result = calculator.CalculateFactorial(n);

            // Assert
            Assert.Equal(expectedFactorial, result);
        }
    }
}
