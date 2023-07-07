class Pr
{
    // Validare parola.
    // Lungimea  > 6
    // Macar o cifra

    // Aruncati exceptie daca parola nu corespunde standartelor
    // Prindeti exceptia si un mesaj corespunzator la consola.

    static void Main()
    {
        try
        {
            string parola = Console.ReadLine();

            // CTRL + .
            ValidareParola(parola);

            Console.WriteLine("Parola este valida!");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Parola nu poate fi null");
            Console.WriteLine($"Detalii: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Parola invalida");
            Console.WriteLine($"Detalii: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("S-a produs o eroare necunoscuta.");
        }
    }

    private static void ValidareParola(string? parola)
    {
        if (parola is null)
        {
            throw new ArgumentNullException("parola");
        }

        if (parola.Length <= 6)
        {
            throw new ArgumentException("Parola nu corespunde standartului de lungime.");
        }

        if (!parola.Any(c => char.IsDigit(c)))
        {
            throw new ArgumentException("Parola trebuie sa contina macar o cifra");
        }
    }
}