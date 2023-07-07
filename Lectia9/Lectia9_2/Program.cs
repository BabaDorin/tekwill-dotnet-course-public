class Pr
{
    static void Main()
    {
        int n = 0;

        var random = new Random();
        int luckyNumber = random.Next(1, 11);

        while (true)
        {
            Console.Write("Introdu un numar: ");
            n = int.Parse(Console.ReadLine());

            if (n == luckyNumber)
            {
                Console.WriteLine("Felicitari! Ati ghicit numarul norocos! " + luckyNumber);
                break;
            }
            else
            {
                Console.WriteLine("Mai incearca");
            }
        }
    }
}