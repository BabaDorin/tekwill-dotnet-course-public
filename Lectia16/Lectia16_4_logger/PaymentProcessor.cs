namespace Lectia16_4_logger
{
    internal class PaymentProcessor
    {
        private ILogger _logger;

        public PaymentProcessor(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessPayment()
        {
            string id = Guid.NewGuid().ToString(); 

            _logger.LogInfo("Started to process payment. PaymentId: " + id);
            // ...
        }
    }
}
