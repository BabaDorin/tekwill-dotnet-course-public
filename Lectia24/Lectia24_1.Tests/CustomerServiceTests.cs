using Moq;
using Xunit;

namespace Lectia24_1.Tests
{
    public class CustomerServiceTests
    {
        [Fact]
        public void GetCusomterName_CustomerFound_ShouldReturnCustomerName()
        {
            // Arrange
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            var sut = new CustomerService(customerRepositoryMock.Object);

            customerRepositoryMock.Setup(m => m.GetCustomerById(1001))
                .Returns(new Customer { Name = "Andrei" });

            // Act
            var customerName = sut.GetCustomerName(1001);

            // Assert
            Assert.Equal("Andrei", customerName);
            customerRepositoryMock.Verify(m => m.GetCustomerById(1001), Times.Once);
        }

        [Fact]
        public void GetCusomterName_CustomerFoundButNameIsNull_ShouldReturnUnknown()
        {
            // Arrange
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            var sut = new CustomerService(customerRepositoryMock.Object);

            customerRepositoryMock.Setup(m => m.GetCustomerById(1001))
                .Returns(new Customer { Name = null });

            // Act
            var customerName = sut.GetCustomerName(1001);

            // Assert
            Assert.Equal("Unknown", customerName);
            customerRepositoryMock.Verify(m => m.GetCustomerById(1001), Times.Once);
        }

        [Fact]
        public void GetCusomterName_CustomerNotFound_ShouldReturnUnknown()
        {
            // Arrange
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            var sut = new CustomerService(customerRepositoryMock.Object);

            customerRepositoryMock.Setup(m => m.GetCustomerById(1001))
                .Returns((Customer)null);

            // Act
            var customerName = sut.GetCustomerName(1001);

            // Assert
            Assert.Equal("Unknown", customerName);
            customerRepositoryMock.Verify(m => m.GetCustomerById(1001), Times.Once);
        }
    }
}
