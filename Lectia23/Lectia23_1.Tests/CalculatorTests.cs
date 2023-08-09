using Xunit;

namespace Lectia23_1.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(10, 1, 11)]
        [InlineData(1, 1, 2)]
        public void Add_ShouldReturnSumOfTwoNumbers(int a, int b, int expectedResult)
        {
            // Arrange
            // sut = system under test
            var sut = new Calculator();

            // Act
            var result = sut.Add(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
