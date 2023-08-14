public class OrderService
{
    private readonly IOrderValidator _orderValidator;
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderValidator orderValidator, IOrderRepository orderRepository)
    {
        _orderValidator = orderValidator;
        _orderRepository = orderRepository;
    }

    public bool Add(Order order)
    {
        if (!_orderValidator.ValidateOrder(order))
        {
            return false; // Validarea a eșuat
        }

        _orderRepository.AddOrder(order);
        return true;
    }
}
