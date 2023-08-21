using System;
using Xunit;

namespace Lectia24_hw_1.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldAddTwoNumbers()
        {
            // ....
            Assert.True(true);
        }

        [Fact]
        public void Substract_ShouldSubstractTwoNumbers()
        {
            // ....
            Assert.True(true);
        }

        [Fact]
        public void Multiply_ShouldMultiplyTwoNumbers()
        {
            // ....
            Assert.True(true);
        }

        [Fact]
        public void Divide_DivisorIsZero_ShouldThrowException()
        {
            // Arrange
            var sut = new Calculator();

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => sut.Divide(5, 0));
        }

        [Fact]
        public void Divide_DivisorIsNotZero_ShouldDivide()
        {
            // Arrange
            var sut = new Calculator();

            // Act
            var result = sut.Divide(4, 2);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
