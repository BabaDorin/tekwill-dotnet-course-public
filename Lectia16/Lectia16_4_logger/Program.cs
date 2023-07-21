using Lectia16_4_logger;

class Program
{
    static void Main()
    {
        ILogger logger = new AzureLogger();

        var paymentProcessor = new PaymentProcessor(logger);
        var userManager = new UserManager(logger);
    }
}
