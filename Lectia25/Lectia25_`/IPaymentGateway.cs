public interface IPaymentGateway
{
    PaymentResult ProcessPayment(PaymentInfo paymentInfo);
}
