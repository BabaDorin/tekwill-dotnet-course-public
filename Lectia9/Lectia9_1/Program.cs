class Pr
{
    static void Main()
    {
        int startInterval = 3;
        int endInterval = 30;

        for (int i = startInterval; i <= endInterval; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i);
        }
    }
}