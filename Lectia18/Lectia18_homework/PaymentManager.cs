namespace Lectia18_homework
{
    internal class PaymentManager : IPaymentManager
    {
        private readonly ILogger _logger;

        private double minTax = 0.15;

        public PaymentManager(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessPayment(double amount, string creditCardNumber)
        {
            _logger.LogInformation("Started to process payment.");

            if (amount <= 0)
            {
                _logger.LogWarning("Amount must be pozitive");
            }

            if (amount <= minTax)
            {
                _logger.LogWarning($"Amount must be greater that the min tax value: {minTax}");
            }

            try
            {
                // ....
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occured: {ex.Message}");
            }
        }

        public void ProcessRefund(double amount, string transactionId)
        {
            throw new NotImplementedException();
        }

        public void RefundPayment(double amount, string transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
