public interface IPaymentRepository
{
    void SavePayment(PaymentInfo paymentInfo, PaymentResult paymentResult);
}
