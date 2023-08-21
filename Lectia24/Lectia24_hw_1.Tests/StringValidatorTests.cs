using Xunit;

namespace Lectia24_hw_1.Tests
{
    public class StringValidatorTests
    {
        [Theory]
        [InlineData("dorin.b@gmail.com")]
        [InlineData("alex.alex@gmail.com")]
        [InlineData("alex.a@yahoo.com")]
        public void IsValidEmail_EmailIsValid_ShouldReturnTrue(string email)
        {
            // Arrange
            var sut = new StringValidator();

            // Act
            var result = sut.IsValidEmail(email);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("dorinb@gmail")]
        [InlineData("dorinbgmail.com")]
        [InlineData("alexa@gmailcom")]
        public void IsValidEmail_EmailIsInvalid_ShouldReturnFalse(string email)
        {
            // Arrange
            var sut = new StringValidator();

            // Act
            var result = sut.IsValidEmail(email);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("1234567890")]
        [InlineData("1534567891")]
        public void IsPhoneNumber_ValidPhoneNumber_ShouldReturnTrue(string phoneNumber)
        {
            // Arrange
            var sut = new StringValidator();

            // Act
            var result = sut.IsPhoneNumber(phoneNumber);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("1234567432432890")]
        [InlineData("15--567891")]
        public void IsPhoneNumber_InvalidPhoneNumber_ShouldReturnFalse(string phoneNumber)
        {
            // Arrange
            var sut = new StringValidator();

            // Act
            var result = sut.IsPhoneNumber(phoneNumber);

            // Assert
            Assert.False(result);
        }
    }
}
