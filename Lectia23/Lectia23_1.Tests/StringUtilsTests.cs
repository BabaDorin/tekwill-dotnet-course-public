using Xunit;

namespace Lectia23_1.Tests
{
    public class StringUtilsTests
    {
        [Theory]
        [InlineData("abc", "cba")]
        [InlineData("123", "321")]
        public void Reverse_ShouldReturnReversedString(
            string input,
            string expectedResult)
        {
            // Arrange
            var sut = new StringUtils();

            // Act
            var result = sut.Reverse(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("ana")]
        [InlineData("potop")]
        [InlineData("capac")]
        public void IsPalindrome_ShouldReturnTrue(string input)
        {
            // Arrange
            var sut = new StringUtils();

            // Act
            var result = sut.IsPalindrome(input);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("abcde")]
        [InlineData("tekwill")]
        [InlineData("internet explorer")]
        public void IsPalindrome_ShouldReturnFalse(string input)
        {
            // Arrange
            var sut = new StringUtils();

            // Act
            var result = sut.IsPalindrome(input);

            // Assert
            Assert.False(result);
        }
    }
}
