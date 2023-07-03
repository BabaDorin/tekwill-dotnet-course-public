using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Console.Write("Introdu numarul de elevi: ");
        int nrElevi = int.Parse(Console.ReadLine());

        var mediileSemestriale = new int[nrElevi];

        //int i = 0;
        //while (i < nrElevi)
        //{
        //    Console.Write($"Introdu media studentului {i+1}: ");
        //    mediileSemestriale[i] = int.Parse(Console.ReadLine());
        //    i++;
        //}

        for (int i = 0; i < nrElevi; i++)
        {
            Console.Write($"Introdu media studentului {i + 1}: ");
            mediileSemestriale[i] = int.Parse(Console.ReadLine());
        }

        //i = 0;
        //while (i < nrElevi)
        //{
        //    
        //if (mediileSemestriale[i] > 8.5)
        //{
        //    nrEleviCuMediaMaiMareDe850++;
        //}
        //    i++;
        //}

        //for (int i = 0; i < nrElevi; i++)
        //{
        //    if (mediileSemestriale[i] > 8.5)
        //    {
        //        nrEleviCuMediaMaiMareDe850++;
        //    }
        //}

        /*
        
        1 3 4 2 2 1 0
        3 2 3 2 1 1 0
        0 0 0 0 3 4 0
        9 9 9 9 9 9 0
         
         */

        int nrEleviCuMediaMaiMareDe850 = mediileSemestriale.Count(mediile => mediile > 8.5);

        Console.WriteLine(nrEleviCuMediaMaiMareDe850);

        /*
         
        1 3 4 2 2 1 0
        3 2 3 2 1 1 0
        0 0 0 0 3 4 0
        9 9 9 9 9 9 0
         
         */

        var matrice = new int[4, 7]
        {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 1, 2, 3, 4, 5, 6, 7 },
            { 1, 2, 3, 4, 5, 6, 7 },
            { 1, 2, 3, 4, 5, 6, 7 },
        };

        int verzisori = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                verzisori += matrice[i, j];
            }
        }

        Console.WriteLine(verzisori);
    }
}