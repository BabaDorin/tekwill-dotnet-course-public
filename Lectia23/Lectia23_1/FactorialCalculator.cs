public class FactorialCalculator
{
    // 3! = 1 * 2 * 3 = 6
    // 4! = 1 * 2 * 3 * 4 = 24
    public int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;

        return n * CalculateFactorial(n - 1);
    }
}
