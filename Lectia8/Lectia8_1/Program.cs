class Program
{
    static void Main()
    {
        int nrLinii = 8;
        int nrColoane = 8;

        int alb = 1;
        int negru = 0;

        int[,] tablaSah = new int[nrLinii, nrColoane];

        for (int i = 0; i < nrLinii; i++)
        {
            for (int j = 0; j < nrColoane; j++)
            {
                tablaSah[i, j] = (i + j) % 2 == 0 ? alb : negru;
            }
        }

        for (int i = 0; i < nrLinii; i++)
        {
            for (int j = 0; j < nrColoane; j++)
            {
                Console.Write(tablaSah[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}