using Lectia24_1.Tests.Mocks;
using Xunit;

namespace Lectia24_1.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void NotifyUser_ShouldCallSendEmailWithExpectedParameters()
        {
            // Arrange
            var emailServiceMock = new EmailServiceMock();
            var sut = new UserService(emailServiceMock);

            var user = new User
            {
                Email = "user.email@gmail.com",
                Name = "User"
            };

            // Act
            sut.NotifyUser(user);

            // Assert
            Assert.True(emailServiceMock.SendEmailCalled);
            Assert.Equal(user.Email, emailServiceMock.LastRecipient);
            Assert.Equal("Notification", emailServiceMock.LastSubject);
            Assert.Equal(
                $"Hello, {user.Name}! You have a new notification.",
                emailServiceMock.LastBody);
        }
    }
}
