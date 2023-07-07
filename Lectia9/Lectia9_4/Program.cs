class Pr
{
    static void Main(string[] args)
    {
        try
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("!!!!!!!!");
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("!!!!!!!!");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Impartirea la 0 nu are sens");
            Console.WriteLine($"Detalii: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ati introdus valori invalide.");
            Console.WriteLine($"Detalii: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("S-a produs o eroare necunoscuta.");
        }
    }
}