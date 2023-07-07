class Pr
{
    static void Main()
    {
        try
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 2)
            {
                throw new Exception("N nu poate fi 2");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}