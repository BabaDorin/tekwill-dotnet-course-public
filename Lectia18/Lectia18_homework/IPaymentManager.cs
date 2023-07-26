namespace Lectia18_homework
{
    internal interface IPaymentManager
    {
        void ProcessPayment(double amount, string creditCardNumber);

        void RefundPayment(double amount, string transactionId);

        void ProcessRefund(double amount, string transactionId);
    }
}
