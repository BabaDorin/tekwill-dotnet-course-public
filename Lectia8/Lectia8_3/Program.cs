class Program
{
    static void Main()
    {
        double[] numbers = new double[] { 3, 6, 1, 0 };

        var sum = CalculateSum(numbers);

        double average = CalculateAverage(numbers);

        SortArrayWithBubbleSort(numbers);

        // Introspection sort
        Array.Sort(numbers);
    }

    static double CalculateSum(double[] numbers)
    {
        // Calcularea sumei
        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }

        var sumLinq = numbers.Sum();

        return sumLinq;
    }

    private static double CalculateAverage(double[] numbers)
    {
        // Calcularea sumei
        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }

        // Calcularea mediei
        var average = sum / numbers.Length;

        var averageLinq = numbers.Average();

        return average;
    }

    private static void SortArrayWithBubbleSort(double[] numbers)
    {
        int n = numbers.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    var aux = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = numbers[j];
                }
            }
        }
    }

    private static void Concat(double[] numbers1, double[] numbers2)
    {
        // concatenatedArray = 1 2 3 4
        // numbers1 = 1 2
        // numbers2 = 3 4

        double[] concatenatedArray = new double[numbers1.Length + numbers2.Length];

        int concatenatedArrayIndex = 0;

        foreach(var number in numbers1)
        {
            concatenatedArray[concatenatedArrayIndex] = number;
            concatenatedArrayIndex++;
        }

        foreach (var number in numbers2)
        {
            concatenatedArray[concatenatedArrayIndex] = number;
            concatenatedArrayIndex++;
        }

        var concatenatedArrayLinq = numbers1.Concat(numbers2).ToArray();
    }
}