namespace Lectia17_1
{
    internal static class UseOfIenumerable
    {
        // Sa se afiseze toate numerele intregi pare dintr-o colectie.
        public static void AfisareNumerePare(IEnumerable<int> colectie)
        {
            foreach (var numar in colectie)
            {
                if (numar % 2 == 0)
                {
                    Console.WriteLine(numar);
                }
            }
        }
    }
}
