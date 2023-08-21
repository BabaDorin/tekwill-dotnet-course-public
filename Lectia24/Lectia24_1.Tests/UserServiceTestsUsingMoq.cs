using Moq;
using Xunit;

namespace Lectia24_1.Tests
{
    public class UserServiceTestsUsingMoq
    {
        [Fact]
        public void NotifyUser_ShouldCallSendEmail()
        {
            // Arrange
            var emailServicemock = new Mock<IEmailService>();
            var sut = new UserService(emailServicemock.Object);

            var user = new User
            {
                Email = "user.email@gmail.com",
                Name = "User"
            };

            // Act
            sut.NotifyUser(user);

            // Assert
            emailServicemock.Verify(m => m.SendEmail(
                user.Email,
                "Notification",
                $"Hello, {user.Name}! You have a new notification."),
                Times.Once);
        }
    }
}
