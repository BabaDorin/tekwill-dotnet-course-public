class Program
{
    private static int lastTicketIndex = 0;
    private static Queue<string> ticketQueue = new Queue<string>();

    static void Main()
    {
        EnqueueCustomer();
        EnqueueCustomer();
        EnqueueCustomer();
        EnqueueCustomer();
        EnqueueCustomer();
        EnqueueCustomer();

        var customer = ticketQueue.Dequeue();
        customer = ticketQueue.Dequeue();
        customer = ticketQueue.Dequeue();
        customer = ticketQueue.Dequeue();
        customer = ticketQueue.Dequeue();
        customer = ticketQueue.Dequeue();
        customer = ticketQueue.Peek();
    }

    public static void EnqueueCustomer()
    {
        ticketQueue.Enqueue($"A{lastTicketIndex++}");
    }
}