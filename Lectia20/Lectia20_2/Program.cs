class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<string, string>();

        dictionary.Add(
            "indubitabil",
            "Cert, incontestabil, neîndoielnic, neîndoios, sigur.");

        dictionary.Add(
            "nesimțibilitate",
            "Nesimțire (1).");

        dictionary.Add(
            "dugos",
            "1 Încăpățânat. 2 Posac");

        dictionary.Add(
           "dugos",
           "1 Încăpățânat. 2 Posac");

        dictionary.Add(
            "lactogen",
            "(Hormon) care stimulează lactația.");

        while (true)
        {
            Console.Write("Cuvantul: ");
            var cuvant = Console.ReadLine();

            var explicatie = dictionary.GetValueOrDefault(cuvant);

            Console.WriteLine($"Explicatia: {explicatie}");
        }
    }
}