class Pr
{
    static void Main()
    {
        int a = 0, n = 3;

        try
        {
            int x = a / n;
            Console.WriteLine($"x = {x}");
        }
        catch (DivideByZeroException) when (a == 3)
        {
            Console.WriteLine("Valoarea variabilei a trebuie sa fie diferita de 3");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"A aparut o situatie de exceptie: {ex.Message}");
        }

    }
}