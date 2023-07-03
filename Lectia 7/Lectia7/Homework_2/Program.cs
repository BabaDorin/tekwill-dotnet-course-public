class Program
{
    static void Main()
    {
        Console.Write("Introdu nota de la test: ");
        var nota = double.Parse(Console.ReadLine());

        Console.WriteLine($"Calificativul dvs. {DeterminaCalificativul(nota)}");
    }

    static string DeterminaCalificativul(double nota)
    {
        if (nota > 0 && nota < 5) return "Necalificat";

        if (nota >= 5 && nota < 8) return "Suficient";

        if (nota >= 8 && nota < 10) return "Bun";

        if (nota == 10) return "Excelent";

        return "Calificativul nu poate fi determinat. Introdu o nota valida.";
    }
}