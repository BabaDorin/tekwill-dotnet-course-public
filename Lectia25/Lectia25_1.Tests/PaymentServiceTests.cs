using AutoFixture;
using Moq;
using Xunit;

namespace Lectia25_1.Tests
{
    public class PaymentServiceTests
    {
        private readonly Mock<IPaymentValidator> paymentValidatorMock;
        private readonly Mock<IPaymentGateway> paymentGatewayMock;
        private readonly Mock<IPaymentRepository> paymentRepositoryMock;
        private readonly Mock<ILogger> loggerMock;
        private readonly PaymentService sut;

        public PaymentServiceTests()
        {
            paymentValidatorMock = new Mock<IPaymentValidator>();
            paymentGatewayMock = new Mock<IPaymentGateway>();
            paymentRepositoryMock = new Mock<IPaymentRepository>();
            loggerMock = new Mock<ILogger>();

            sut = new PaymentService(
                paymentValidatorMock.Object,
                paymentGatewayMock.Object,
                paymentRepositoryMock.Object,
                loggerMock.Object);
        }

        [Fact]
        public void ProcessPayment_InvalidPaymentInfo_ShouldReturnFalse()
        {
            // Arrange
            paymentValidatorMock.Setup(m => m.ValidatePayment(It.IsAny<PaymentInfo>()))
                .Returns(false);

            // Autofixture
            var paymentInfo = new Fixture().Create<PaymentInfo>();

            // Act
            var result = sut.ProcessPayment(paymentInfo);

            // Assert
            paymentValidatorMock.Verify(m => m.ValidatePayment(paymentInfo), Times.Once);
            Assert.False(result);
            paymentGatewayMock.Verify(m => m.ProcessPayment(It.IsAny<PaymentInfo>()), Times.Never);
        }

        [Fact]
        public void ProcessPayment_ValidPaymentInfo_Success_ShouldCallPaymentGatewayAndReturnTrue()
        {
            // Arrange
            paymentValidatorMock.Setup(m => m.ValidatePayment(It.IsAny<PaymentInfo>()))
                .Returns(true);

            var paymentResult = new PaymentResult
            {
                Success = true
            };

            paymentGatewayMock
                .Setup(m => m.ProcessPayment(It.IsAny<PaymentInfo>()))
                .Returns(paymentResult);

            // Autofixture
            var paymentInfo = new Fixture().Create<PaymentInfo>();

            // Act
            var result = sut.ProcessPayment(paymentInfo);

            // Assert
            paymentValidatorMock.Verify(m => m.ValidatePayment(paymentInfo), Times.Once);
            Assert.True(result);
            paymentGatewayMock.Verify(m => m.ProcessPayment(paymentInfo), Times.Once);
        }

        [Fact]
        public void ProcessPayment_ValidPaymentInfo_Fail_ShouldCallPaymentGatewayAndReturnFalse()
        {
            // Arrange
            paymentValidatorMock.Setup(m => m.ValidatePayment(It.IsAny<PaymentInfo>()))
                .Returns(true);

            var paymentResult = new PaymentResult
            {
                Success = false
            };

            paymentGatewayMock
                .Setup(m => m.ProcessPayment(It.IsAny<PaymentInfo>()))
                .Returns(paymentResult);

            // Autofixture
            var paymentInfo = new Fixture().Create<PaymentInfo>();

            // Act
            var result = sut.ProcessPayment(paymentInfo);

            // Assert
            paymentValidatorMock.Verify(m => m.ValidatePayment(paymentInfo), Times.Once);
            Assert.False(result);
            paymentGatewayMock.Verify(m => m.ProcessPayment(paymentInfo), Times.Once);
        }

        [Fact]
        public void ProcessPayment_ValidPaymentInfo_ShouldCallSavePayment()
        {
            // Arrange
            paymentValidatorMock.Setup(m => m.ValidatePayment(It.IsAny<PaymentInfo>()))
                .Returns(true);

            var paymentResult = new PaymentResult
            {
                Success = true
            };

            paymentGatewayMock
                .Setup(m => m.ProcessPayment(It.IsAny<PaymentInfo>()))
                .Returns(paymentResult);

            // Autofixture
            var paymentInfo = new Fixture().Create<PaymentInfo>();

            // Act
            var result = sut.ProcessPayment(paymentInfo);

            // Assert
            paymentValidatorMock.Verify(m => m.ValidatePayment(paymentInfo), Times.Once);
            Assert.True(result);
            paymentRepositoryMock.Verify(m => m.SavePayment(paymentInfo, paymentResult), Times.Once);
        }

        [Fact]
        public void ProcessPayment_ValidPaymentInfo_ShouldCallLogEvent()
        {
            // Arrange
            paymentValidatorMock.Setup(m => m.ValidatePayment(It.IsAny<PaymentInfo>()))
                .Returns(true);

            var paymentResult = new PaymentResult
            {
                Success = true
            };

            paymentGatewayMock
                .Setup(m => m.ProcessPayment(It.IsAny<PaymentInfo>()))
                .Returns(paymentResult);

            // Autofixture
            var paymentInfo = new Fixture().Create<PaymentInfo>();

            // Act
            var result = sut.ProcessPayment(paymentInfo);

            // Assert
            paymentValidatorMock.Verify(m => m.ValidatePayment(paymentInfo), Times.Once);
            Assert.True(result);
            loggerMock.Verify(m => m.LogEvent($"Payment processed for {paymentInfo.Amount:C}"), Times.Once);
        }
    }
}
