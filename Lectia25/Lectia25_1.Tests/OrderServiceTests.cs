using AutoFixture;
using Moq;
using Xunit;

namespace Lectia25_1.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void Add_InvalidOrder_ShouldReturnFalse()
        {
            // Arrange
            var orderValidatorMock = new Mock<IOrderValidator>();
            var orderRepositoryMock = new Mock<IOrderRepository>();

            orderValidatorMock
                .Setup(m => m.ValidateOrder(It.IsAny<Order>()))
                .Returns(false);

            var sut = new OrderService(
                orderValidatorMock.Object,
                orderRepositoryMock.Object);

            var order = new Fixture().Create<Order>();

            // Act
            var result = sut.Add(order);

            // Assert
            orderValidatorMock.Verify(m => m.ValidateOrder(order), Times.Once);
            Assert.False(result);
            orderRepositoryMock.Verify(m => m.AddOrder(order), Times.Never);
        }

        [Fact]
        public void Add_ValidOrder_ShouldReturnTrue()
        {
            // Arrange
            var orderValidatorMock = new Mock<IOrderValidator>();
            var orderRepositoryMock = new Mock<IOrderRepository>();

            orderValidatorMock
                .Setup(m => m.ValidateOrder(It.IsAny<Order>()))
                .Returns(true);

            var sut = new OrderService(
                orderValidatorMock.Object,
                orderRepositoryMock.Object);

            var order = new Fixture().Create<Order>();

            // Act
            var result = sut.Add(order);

            // Assert
            orderValidatorMock.Verify(m => m.ValidateOrder(order), Times.Once);
            Assert.True(result);
            orderRepositoryMock.Verify(m => m.AddOrder(order), Times.Once);
        }
    }
}
