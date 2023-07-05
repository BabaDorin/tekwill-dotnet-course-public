class Program
{
    static void Main(string[] args)
    {
        int n;
        int notePozitive = 0, noteNegative = 0, sumaNotePozitive = 0;

        Console.Write("Introdu numarul de note n= ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu notele:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Nota {0}: ", i);
            int nota = int.Parse(Console.ReadLine());

            if (nota > 4)
            {
                notePozitive++;
                sumaNotePozitive = sumaNotePozitive + nota;
            }
            else
            {
                noteNegative++;
            }
        }

        if (noteNegative == 0)
        {
            double mediap = (double)sumaNotePozitive / notePozitive;
            Console.WriteLine("Numărul notelor pozitive: {0}", notePozitive);
            Console.WriteLine("Media notelor pozitive este: {0:f2}", mediap);
        }
        else
        {
            Console.WriteLine("Corigent, note negative: {0}", noteNegative);
        }

        Console.ReadKey();
    }
}

