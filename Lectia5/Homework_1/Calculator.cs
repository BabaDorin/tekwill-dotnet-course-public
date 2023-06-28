namespace Homework_1
{
    public class Calculator
    {
        public static void Implimemtare()
        {
            Console.WriteLine(" Dati primul numar:");
            int numar1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Dati al doilea numar:");
            int numar2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Alege operatia + sau - ");
            char semn = Console.ReadKey().KeyChar;

            if (semn == '+')
            {
                long suma = numar1 + numar2;
                Console.WriteLine("\nSuma este: " + suma);
            }

            if (semn == '-')
            {
                int diferenta = numar1 - numar2;
                Console.WriteLine("\nDiferenta este: " + diferenta);
            }
        }
    }
}
