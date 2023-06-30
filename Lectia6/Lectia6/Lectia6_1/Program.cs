class Program
{
    static void Main(string[] args)
    {
        // Cititi de la tastatura o parola
        // Validati daca parola este una valida, conform urmatoarelor
        // criterii de validitate:
        // 1. DONE Parola sa contina minim 6 caractere.
        // 2. DONE Parola sa contina macar o litera Mare
        // 3. DONE Parola sa contina macar o litera mica
        // 4. DONE Parola sa contina macar o cifra
        // 5. DONE Parola sa nu contina spatii.

        while (true)
        {
            Console.Write("Introdu o parola pentru a fi validata: ");
            string password = Console.ReadLine()!;

            var isValid = IsValid(password);

            Console.WriteLine("Parola indicata este: " + (isValid ? "valida" : "invalida"));
        }
    }

    public static bool IsValid(string password)
    {
        if (password.Length < 6)
        {
            return false;
        }

        if (!password.Any(c => char.IsUpper(c)))
        {
            return false;
        }

        if (!password.Any(c => char.IsLower(c)))
        {
            return false;
        }

        if (!password.Any(c => char.IsDigit(c)))
        {
            return false;
        }

        if (password.Contains(' '))
        {
            return false;
        }

        return true;
    }
}
