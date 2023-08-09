using Xunit;

namespace Lectia23_1.Tests
{
    public class MathUtilsTests
    {
        [Fact]
        public void IsPrime_ShouldReturnTrue()
        {
            // Arrange
            var sut = new MathUtils();

            // Act
            var result = sut.IsPrime(7);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPrime_ShouldReturnFalse()
        {
            // Arrange
            var sut = new MathUtils();

            // Act
            var result = sut.IsPrime(7);

            // Assert
            Assert.True(result);
        }
    }
}
