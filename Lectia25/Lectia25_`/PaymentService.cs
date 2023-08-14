public class PaymentService
{
    private readonly IPaymentValidator _paymentValidator;
    private readonly IPaymentGateway _paymentGateway;
    private readonly IPaymentRepository _paymentRepository;
    private readonly ILogger _logger;

    public PaymentService(
        IPaymentValidator paymentValidator,
        IPaymentGateway paymentGateway,
        IPaymentRepository paymentRepository,
        ILogger logger)
    {
        _paymentValidator = paymentValidator;
        _paymentGateway = paymentGateway;
        _paymentRepository = paymentRepository;
        _logger = logger;
    }

    public bool ProcessPayment(PaymentInfo paymentInfo)
    {
        // Validate payment
        if (!_paymentValidator.ValidatePayment(paymentInfo))
        {
            return false; // Payment validation failed
        }

        // Simulate processing payment
        var paymentResult = _paymentGateway.ProcessPayment(paymentInfo);

        // Save payment record
        _paymentRepository.SavePayment(paymentInfo, paymentResult);

        // Log payment event
        _logger.LogEvent($"Payment processed for {paymentInfo.Amount:C}");

        return paymentResult.Success;
    }
}
