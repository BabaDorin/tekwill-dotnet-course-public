using Lectia18_homework;

class Program
{
    static void Main()
    {
        var fileLogger = new FileLogger();

        var paymentManager = new PaymentManager(fileLogger);

        paymentManager.ProcessPayment(0.10, "3453455328772734");
    }
}